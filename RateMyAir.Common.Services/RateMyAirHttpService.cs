using RateMyAir.Common.Entities.DTO;
using RateMyAir.Common.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RateMyAir.Common.Services
{
    public class RateMyAirHttpService : BaseHttpService, IRateMyAirHttpService
    {
        public RateMyAirHttpService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory, "RateMyAirClient") { }

        public async Task<AirQualityDtoOut> GetLastAirQualityAsync()
        {
            return (await GetAsync<Response<AirQualityDtoOut>>("airquality/last")).Data;
        }

        public async Task<List<AirQualityDtoOut>> GetAirQualityAsync()
        {
            return (await GetAsync<Response<List<AirQualityDtoOut>>>("airquality")).Data;
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync()
        {
            return (await GetAsync<Response<List<AirQualityIndexDtoOut>>>("airquality/dailyindex")).Data;
        }

        public async Task<List<AirQualityDtoOut>> GetAirQualityAsync(DateTime fromDate, DateTime toDate)
        {
            return (await GetAsync<Response<List<AirQualityDtoOut>>>("airquality")).Data;
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(DateTime fromDate, DateTime toDate)
        {
            string endpoint = String.Format("airquality/dailyindex?fromDate={0}", fromDate.ToString("dd-MM-yyyy"));
            return (await GetAsync<Response<List<AirQualityIndexDtoOut>>>(endpoint)).Data;
        }
    }
}
