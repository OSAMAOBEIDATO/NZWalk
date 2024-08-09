using NZWalk.Api.Models.Domain;
using NZWalk.Api.Models.DTOs;

namespace NZWalk.Api.Repository
{
    public interface IRegionRepostory
    {
        Task<List<Region>> GetAllRegionsAsync();
        Task<Region> getSingleRegionAsync(Guid id);
        Task<Region> create(Region region);
        Task<Region?> update(Guid id,Region UPregion);
        Task<Region> Delete(Guid id); 

    }
}
