using NZWalk.Api.Models.Domain;

namespace NZWalk.Api.Repository
{
    public interface IWalkRepository
    {
        Task<Walk> create(Walk walk);
    }
}
