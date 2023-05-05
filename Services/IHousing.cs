using Api.Airbnb.DTO;

namespace Api.Airbnb.Services
{
    public interface IHousing
    {
        Task<List<CatalogHousing>> GetCatalogHousings();
    }
}
