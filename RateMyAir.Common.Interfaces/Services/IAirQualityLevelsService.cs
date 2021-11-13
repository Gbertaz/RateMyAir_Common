using RateMyAir.Common.Entities.Enums;
using RateMyAir.Common.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Services
{
    public interface IAirQualityLevelsService
    {
        Task<List<IndexLevel>> GetAirQualityLevelsAsync();
        Task<List<IndexLevel>> GetAirQualityLevelsAsync(Enums.Pollutants pollutant);

    }
}
