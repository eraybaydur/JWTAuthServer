using AutoMapper;
using JWTAuthServer.Core.DTOs;
using JWTAuthServer.Core.Model;

namespace JWTAuthServer.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<AppUserDto, AppUser>().ReverseMap();
        }
    }
}