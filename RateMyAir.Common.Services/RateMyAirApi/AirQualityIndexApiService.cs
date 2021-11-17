using RateMyAir.Common.Entities.DTO;
using RateMyAir.Common.Interfaces.Filters;
using RateMyAir.Common.Interfaces.HttpClients;
using RateMyAir.Common.Interfaces.Services;
using RateMyAir.Common.Services.HttpClients;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RateMyAir.Common.Services.RateMyAirApi
{
    public class AirQualityIndexApiService : IAirQualityIndexProvider
    {
        private readonly IBaseHttpClient _restService;
        private const string _endpoint = "airquality/dailyindex";

        public AirQualityIndexApiService(IHttpClientFactory httpClientFactory)
        {
            _restService = new RateMyAirHttpClientService(httpClientFactory);
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync()
        {
            return (await _restService.GetAsync<List<AirQualityIndexDtoOut>>(_endpoint)).Data;
        }

        public async Task<List<AirQualityIndexDtoOut>> GetAirQualityIndexAsync(IParametersFormatter paramsFormatter)
        {
            string endpoint = string.Format("{0}?{1}", _endpoint, paramsFormatter.CreateQueryStringParameters());
            return (await _restService.GetAsync<List<AirQualityIndexDtoOut>>(endpoint)).Data;
        }

    }
}
