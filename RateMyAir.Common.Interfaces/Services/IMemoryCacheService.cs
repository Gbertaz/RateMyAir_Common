using RateMyAir.Common.Entities.Enums;
using RateMyAir.Common.Entities.Models;
using System.Collections.Generic;

namespace RateMyAir.Common.Interfaces.Services
{
    public interface IMemoryCacheService
    {
        List<IndexLevel> GetCachedAirQualityLevels();
        List<IndexLevel> GetCachedAirQualityLevels(Enums.Pollutants pollutant);
        void CacheAirQualityLevels(List<IndexLevel> levels);
        void CacheAirQualityLevels(List<IndexLevel> levels, Enums.Pollutants pollutant);
    }
}
