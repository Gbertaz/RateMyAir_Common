﻿using Microsoft.EntityFrameworkCore;
using RateMyAir.Common.Entities.Models;
using RateMyAir.Common.Interfaces.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace RateMyAir.Common.Repositories
{
    public class AirQualityRepository : RepositoryBase<AirQuality>, IAirQualityRepository
    {
        public AirQualityRepository(DatabaseContext repositoryContext) : base(repositoryContext) { }

        public async Task<AirQuality> GetAirQualityByIdAsync(int airQualityId, bool trackChanges)
        {
            return await FindByCondition(x => x.AirQualityId == airQualityId, trackChanges).FirstOrDefaultAsync();
        }

        public Task<AirQuality> GetLastAsync(bool trackChanges)
        {
            return FindByCondition(x => x.AirQualityId > 0, trackChanges).OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync();
        }

        public IQueryable<AirQuality> GetAllAirQuality(bool trackChanges)
        {
            return FindAll(trackChanges);
        }

        public void InsertAirQuality(AirQuality model)
        {
            Create(model);
        }

    }
}