using RateMyAir.Common.Interfaces.Clients;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace RateMyAir.Common.Clients
{
    public class BaseHttpClient : IBaseHttpClient
    {
        private readonly HttpClient _client;

        public BaseHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> GetAsync<T>(string url, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            using (var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(jsonString);
            }
        }
    
    }
}
