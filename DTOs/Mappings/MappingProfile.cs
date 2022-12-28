using AccountApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AccountApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDTO>().ReverseMap();
        CreateMap<Account, AccountDTO>().ReverseMap();

        CreateMap<UserDTO, IdentityUser>()
            .ForMember(dest =>
                dest.UserName,
                opt => opt.MapFrom(src => src.Email));
    }
}
