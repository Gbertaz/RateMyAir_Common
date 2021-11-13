using System.Threading;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Clients
{
    public interface IBaseHttpClient
    {
        Task<T> GetAsync<T>(string url, CancellationToken cancellationToken);
    }
}