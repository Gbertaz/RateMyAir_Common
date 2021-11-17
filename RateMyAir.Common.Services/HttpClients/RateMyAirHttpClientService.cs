using RateMyAir.Common.Entities.Enums;
using RateMyAir.Common.Interfaces.HttpClients;
using System.Net.Http;
using System.Text.Json;

namespace RateMyAir.Common.Services.HttpClients
{
    public class RateMyAirHttpClientService : IBaseHttpClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;

        public RateMyAirHttpClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true  // Ignore case
            };
        }

        IHttpClientFactory IBaseHttpClient.HttpClientFactory => _httpClientFactory;
        string IBaseHttpClient.ClientName => Enums.HttpClients.RateMyAir.ToString();
        JsonSerializerOptions IBaseHttpClient.SerializerOptions => _options;
    }
}
