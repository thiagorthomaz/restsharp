using System.Collections.Generic;
using AutoMapper;
using sharppress.Controllers.Resources;
using sharppress.Models;
using System.Linq;

namespace sharppress.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            //Domain to API resource
            CreateMap<Post, PostResource>()
            .ForMember(pr => pr.Categories, opt => opt.MapFrom( p => p.Categories.Select(pc => pc.CategoryId) ));

            //API Resource to Domain
            CreateMap<PostResource, Post>()
            .ForMember(p => p.Id, opt => opt.Ignore())
            .ForMember(p => p.Categories, opt => opt.Ignore())
            .AfterMap((pr, p) => {

                
                //Remove unselected category
                var removedCategories = p.Categories.Where(pc => !pr.Categories.Contains(pc.CategoryId)).ToList();
                foreach(var c in removedCategories)
                    p.Categories.Remove(c);

                //Add new category
                var addedCategories = pr.Categories.Where(id => !p.Categories.Any(pc => pc.CategoryId == id))
                .Select(id => new PostCategory { CategoryId = id } );

                foreach(var ac in addedCategories)
                    p.Categories.Add(ac);

            });

        }   
    }
}