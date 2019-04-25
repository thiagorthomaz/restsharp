using AutoMapper;
using restsharp.Controllers.Resources;
using restsharp.Models;

namespace restsharp.Mapping
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