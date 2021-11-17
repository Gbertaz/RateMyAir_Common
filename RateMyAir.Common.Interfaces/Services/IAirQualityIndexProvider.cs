using RateMyAir.Common.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Services
{
    public interface IAirQualityIndexProvider
    {
        Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync();
        Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(IAirQualityIndexEndpointProvider endpointProvider);
    }
}
