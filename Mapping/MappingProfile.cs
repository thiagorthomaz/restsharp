using AutoMapper;
using sharppress.Controllers.Resources;
using sharppress.Models;

namespace sharppress.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            //Domain to API resource
            CreateMap<Post, PostResource>();

            //API Resource to Domain
            CreateMap<PostResource, Post>()
            .ForMember(p => p.Id, opt => opt.Ignore());

        }   
    }
}