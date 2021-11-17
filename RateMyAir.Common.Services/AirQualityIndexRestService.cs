using RateMyAir.Common.Entities.DTO;
using RateMyAir.Common.Interfaces;
using RateMyAir.Common.Interfaces.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RateMyAir.Common.Services
{
    public class AirQualityIndexRestService : IAirQualityIndexProvider
    {
        private readonly IBaseHttpRestService _restService;
        private const string _baseEndpoint = "airquality/dailyindex";

        public AirQualityIndexRestService(IHttpClientFactory httpClientFactory)
        {
            _restService = new RateMyAirHttpRestService(httpClientFactory);
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync()
        {
            return (await _restService.GetAsync<List<AirQualityIndexDtoOut>>(_baseEndpoint)).Data;
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(IAirQualityIndexEndpointProvider endpointProvider)
        {
            string endpoint = endpointProvider.CreateEndpoint(_baseEndpoint);
            return (await _restService.GetAsync<List<AirQualityIndexDtoOut>>(endpoint)).Data;
        }

    }
}
