using Api.Airbnb.Models;

namespace Api.Airbnb.DTO
{
    public class CatalogHousing
    {
        public int IdHousing { get; set; }
        public OwnerDTO OwnerDto { get; set; }

        public string NameHousing { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

    }
}
