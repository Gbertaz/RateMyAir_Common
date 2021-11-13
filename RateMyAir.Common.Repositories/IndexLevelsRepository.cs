using Microsoft.EntityFrameworkCore;
using RateMyAir.Common.Entities.Models;
using RateMyAir.Common.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RateMyAir.Common.Repositories
{
    public class IndexLevelsRepository : RepositoryBase<IndexLevel>, IIndexLevelsRepository
    {
        public IndexLevelsRepository(DatabaseContext repositoryContext) : base(repositoryContext) { }

        public async Task<List<IndexLevel>> GetLevelsAsync()
        {
            return await FindAll(false).ToListAsync();
        }
    }

}
