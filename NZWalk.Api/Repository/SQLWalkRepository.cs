using NZWalk.Api.Data;
using NZWalk.Api.Models.Domain;

namespace NZWalk.Api.Repository
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly NZWalkDBContext dBContext;

        public SQLWalkRepository(NZWalkDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task<Walk> create(Walk walk)
        {
            await dBContext.walks.AddRangeAsync(walk);
            await dBContext.SaveChangesAsync();
            return walk;
        }


    }
}
