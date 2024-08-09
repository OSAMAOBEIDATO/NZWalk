using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NZWalk.Api.Data;
using NZWalk.Api.Models.Domain;
using NZWalk.Api.Models.DTOs;

namespace NZWalk.Api.Repository
{
    public class SQLRegionRepository : IRegionRepostory
    {
        public readonly NZWalkDBContext dBContext;
        public SQLRegionRepository(NZWalkDBContext nZWalkDBContext)
        {
            this.dBContext = nZWalkDBContext;
        }

        public async Task<Region> create(Region region)
        {
             await dBContext.regions.AddRangeAsync(region);
             await dBContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region> Delete(Guid id)
        {
            var region = await dBContext.regions.FirstOrDefaultAsync(a => a.id == id);
            if (region == null) 
            {
                return null;
            }
             dBContext.regions.Remove(region);
            await dBContext.SaveChangesAsync();
            return region;
        }

        public async Task<List<Region>> GetAllRegionsAsync()
        {
            return await dBContext.regions.ToListAsync();
        }

        public async Task<Region?> getSingleRegionAsync(Guid id)
        {
           return await dBContext.regions.SingleOrDefaultAsync(a =>a.id ==id);
        }

        public async Task<Region?> update(Guid id, Region UPregion)
        {
            var checkExsting=await dBContext.regions.FirstOrDefaultAsync(a => a.id == id);
            if (checkExsting == null)
            {
                return null;
            }
              checkExsting.code= UPregion.code;
             checkExsting.name= UPregion.name;
            checkExsting.regionImageUrl = UPregion.regionImageUrl;
            await dBContext.SaveChangesAsync();
            return checkExsting;
        
        }

        
    }
}
