using RateMyAir.Common.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Repositories
{
    public interface IIndexLevelsRepository
    {
        Task<List<IndexLevel>> GetLevelsAsync();
    }
}
