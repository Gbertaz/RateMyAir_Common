using RateMyAir.Common.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RateMyAir.Common.Interfaces.Clients
{
    public interface IRateMyAirHttpClient
    {
        Task<AirQualityDtoOut> GetLastAirQualityAsync(string url);
        Task<List<AirQualityDtoOut>> GetAirQualityAsync(string url, DateTime fromDate, DateTime toDate);
        Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(string url, DateTime fromDate, DateTime toDate);
    }
}
