using AutoMapper;
using MVP.Core.DTOs;
using MVP.Core.Entities;

namespace MVP.Infraestructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
