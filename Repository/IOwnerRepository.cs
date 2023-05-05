using Api.Airbnb.Models;

namespace Api.Airbnb.Repository
{
    public interface IOwnerRepository
    {
        Task<List<Owner>> GetAllOwners();
    }
}
