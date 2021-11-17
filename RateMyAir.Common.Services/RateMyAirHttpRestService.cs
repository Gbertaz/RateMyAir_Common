using RateMyAir.Common.Entities.Enums;
using RateMyAir.Common.Interfaces.Services;
using System.Net.Http;
using System.Text.Json;

namespace RateMyAir.Common.Services
{
    public class RateMyAirHttpRestService : IBaseHttpRestService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;

        public RateMyAirHttpRestService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        IHttpClientFactory IBaseHttpRestService.HttpClientFactory => _httpClientFactory;

        string IBaseHttpRestService.ClientName => Enums.HttpClients.RateMyAir.ToString();

        JsonSerializerOptions IBaseHttpRestService.SerializerOptions => _options;
    }
}
