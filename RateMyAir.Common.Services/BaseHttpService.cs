using RateMyAir.Common.Interfaces.Services;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RateMyAir.Common.Services
{
    public class BaseHttpService : IBaseHttpService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string _clientName;

        public BaseHttpService(IHttpClientFactory httpClientFactory, string clientName)
        {
            _httpClientFactory = httpClientFactory;
            _clientName = clientName;
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            var httpClient = _httpClientFactory.CreateClient(_clientName);
            var httpResponseMessage = await httpClient.GetAsync(endpoint);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            //if (httpResponseMessage.IsSuccessStatusCode)
            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(contentStream, options);
        }

    }
}
