using Api.Airbnb.Models;

namespace Api.Airbnb.Repository
{
    public interface IHousingRepository
    {
        Task<List<Housing>> GetAllHousings();   
    }
}
