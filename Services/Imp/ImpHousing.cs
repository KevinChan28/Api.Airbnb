using Api.Airbnb.DBContext;
using Api.Airbnb.DTO;
using Api.Airbnb.Models;
using Api.Airbnb.Repository;

namespace Api.Airbnb.Services.Imp
{
    public class ImpHousing : IHousing
    {
        IHousingRepository _housigRepository;
        IOwnerRepository _ownerRepository;
        public ImpHousing(IHousingRepository housigRepository, IOwnerRepository ownerRepository)
        {
            _housigRepository = housigRepository;
            _ownerRepository = ownerRepository;
        }


        public async Task<List<CatalogHousing>> GetCatalogHousings()
        {
           List<Owner>  owner = await _ownerRepository.GetAllOwners();
            List<Housing> housings = await _housigRepository.GetAllHousings();
            List<CatalogHousing> result = housings.Select(p => new CatalogHousing
            {
                IdHousing = p.Id,
                NameHousing = p.NameHousing,
                Country = p.Country,
                State = p.State,
                OwnerDto = owner.Select(h => new OwnerDTO
                {
                    IdOwner = h.Id,
                    Name = h.Name,
                    Contact = h.Contact,
                    Language = h.Language
                }).Where(a => a.IdOwner == p.IdOwner).FirstOrDefault()
            }).ToList();
           return result;
        }
    }
}
        
    

