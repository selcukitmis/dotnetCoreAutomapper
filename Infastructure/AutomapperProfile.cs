using System;
using AutoMapper;
using Core;
using VM;

namespace Infastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Core.City, VM.City>();
            CreateMap<Core.Token, VM.Token>();
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.City, act => act.MapFrom(src => src.City))
                .ForPath(dest => dest.City.Country, act => act.MapFrom(src => src.City.Country.Name))
                .ForMember(dest => dest.Tokens, opt => opt.MapFrom(src => src.Tokens));
        }
    }
}
