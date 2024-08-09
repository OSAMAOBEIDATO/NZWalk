using AutoMapper;
using NZWalk.Api.Models.Domain;
using NZWalk.Api.Models.DTOs;

namespace NZWalk.Api.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<UpdateRegionRequstDto, Region>().ReverseMap();
            CreateMap<AddRegionRequstDto, Region>().ReverseMap();
            CreateMap<AddWalkrequestTdo, Walk>().ReverseMap();
        }
    }
}
