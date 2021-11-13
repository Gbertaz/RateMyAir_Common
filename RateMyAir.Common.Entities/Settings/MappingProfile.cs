using AutoMapper;
using RateMyAir.Common.Entities.DTO;
using RateMyAir.Common.Entities.DTO.Queries;
using RateMyAir.Common.Entities.Models;

namespace RateMyAir.Common.Entities.Settings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AirQuality, PollutionQueryDto>();
            CreateMap<AirQualityDtoIn, AirQuality>();
            CreateMap<AirQuality, AirQualityDtoOut>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AirQualityId));
        }
    }
}
