using AutoMapper;
using Data.Entities;
using MathCornerForum_aspnetcore.Models;

namespace MathCornerForum_aspnetcore.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<User, UserCreateModel>()
            //    .ForMember(
            //    dest => dest.UserName,
            //    opt => opt.MapFrom(src => $"{src.UserName}")
            //    )/*.ReverseMap()*/;


            //CreateMap<UserCreateModel, User>()
            //    .ForMember(
            //    dest => dest.UserName,
            //    opt => opt.MapFrom(src => $"{src.UserName}")
            //    )
            //    .ForMember(
            //    dest => dest.Password,
            //    opt => opt.MapFrom(src => $"{src.Password}")
            //    )
            //    .ForMember(
            //    dest => dest.Email,
            //    opt => opt.MapFrom(src => $"{src.Email}")
            //    )
            //    .ForMember(
            //    dest => dest.Picture,
            //    opt => opt.MapFrom(src => $"{src.Picture}")
            //    )
            //    .ForMember(
            //    dest => dest.Id,
            //    opt => opt.Ignore()
            //    )
            //    //.ForMember(
            //    //dest => dest.Posts,
            //    //opt => opt.Ignore()
            //    //)
            //    //.ForMember(
            //    //dest => dest.PostReplies,
            //    //opt => opt.Ignore()
            //    //)
            //    /*.ReverseMap()*/;

            CreateMap<User, UserCreateModel>().ReverseMap();
        }
    }
}
