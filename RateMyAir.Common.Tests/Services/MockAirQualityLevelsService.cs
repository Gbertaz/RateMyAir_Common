using RateMyAir.Common.Entities.Enums;
using RateMyAir.Common.Entities.Models;
using RateMyAir.Common.Interfaces.Repositories;
using RateMyAir.Common.Interfaces.Services;
using RateMyAir.Common.Tests.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateMyAir.Common.Tests.Services
{
    public class MockAirQualityLevelsService : IAirQualityLevelsService
    {
        private readonly IRepositoryManager _repoManager;

        public MockAirQualityLevelsService()
        {
            _repoManager = new MockRepositoryManager();
        }

        public async Task<List<IndexLevel>> GetAirQualityLevelsAsync()
        {
            return await _repoManager.IndexLevels.GetLevelsAsync();
        }

        public async Task<List<IndexLevel>> GetAirQualityLevelsAsync(Enums.Pollutants pollutant)
        {
            return (await _repoManager.IndexLevels.GetLevelsAsync()).Where(x => x.Pollutant == pollutant.ToString()).ToList();
        }
    }
}
