﻿using System;
using System.Threading.Tasks;

namespace RateMyAir.Common.Interfaces.Repositories
{
    public interface IRepositoryManager : IDisposable
    {
        IAirQualityRepository AirQuality { get; }
        IIndexLevelsRepository IndexLevels { get; }
        Task<int> SaveAsync();
    }
}
