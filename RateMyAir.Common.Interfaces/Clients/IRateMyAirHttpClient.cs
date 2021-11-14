using RateMyAir.Common.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RateMyAir.Common.Interfaces.Clients
{
    public interface IRateMyAirHttpClient
    {
        Task<AirQualityDtoOut> GetLastAirQualityAsync();
        Task<List<AirQualityDtoOut>> GetAirQualityAsync();
        Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync();
        Task<List<AirQualityDtoOut>> GetAirQualityAsync(DateTime fromDate, DateTime toDate);
        Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(DateTime fromDate, DateTime toDate);
    }
}