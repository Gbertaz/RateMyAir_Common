using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Services
{
    public interface IBaseHttpService
    {
        Task<T> GetAsync<T>(string endpoint);
    }
}