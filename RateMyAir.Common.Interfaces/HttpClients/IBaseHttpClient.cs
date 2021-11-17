using RateMyAir.Common.Entities.DTO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.HttpClients
{
    public interface IBaseHttpClient
    {
        protected abstract IHttpClientFactory HttpClientFactory { get; }
        protected abstract string ClientName { get; }
        protected abstract JsonSerializerOptions SerializerOptions { get; }
        virtual async Task<Response<T>> GetAsync<T>(string endpoint)
        {
            var httpClient = HttpClientFactory.CreateClient(ClientName);
            var httpResponseMessage = await httpClient.GetAsync(endpoint);
            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Response<T>>(contentStream, SerializerOptions);
        }
    }
}
