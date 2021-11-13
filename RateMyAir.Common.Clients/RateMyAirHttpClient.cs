using RateMyAir.Common.Entities.DTO;
using RateMyAir.Common.Interfaces.Clients;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RateMyAir.Common.Clients
{
    public class RateMyAirHttpClient : IRateMyAirHttpClient
    {
        private readonly IBaseHttpClient _baseClient;

        public RateMyAirHttpClient(IBaseHttpClient baseClient)
        {
            _baseClient = baseClient;
        }

        public async Task<AirQualityDtoOut> GetLastAirQualityAsync(string url)
        {
            return (await _baseClient.GetAsync<Response<AirQualityDtoOut>>(url, new CancellationToken())).Data;
        }

        public async Task<List<AirQualityDtoOut>> GetAirQualityAsync(string url, DateTime fromDate, DateTime toDate)
        {
            return (await _baseClient.GetAsync<Response<List<AirQualityDtoOut>>>(url, new CancellationToken())).Data;
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(string url, DateTime fromDate, DateTime toDate)
        {
            return (await _baseClient.GetAsync<Response<List<AirQualityIndexDtoOut>>>(url, new CancellationToken())).Data;
        }
    }

}
