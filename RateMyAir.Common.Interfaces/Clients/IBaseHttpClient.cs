using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Clients
{
    public interface IBaseHttpClient
    {
        Task<T> GetAsync<T>(string endpoint);
    }
}