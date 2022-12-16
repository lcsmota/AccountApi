using AccountApi.Models;
using AutoMapper;

namespace AccountApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDTO>().ReverseMap();
        CreateMap<Account, AccountDTO>().ReverseMap();
    }
}
