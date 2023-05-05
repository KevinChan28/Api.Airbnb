using Api.Airbnb.DBContext;
using Api.Airbnb.Models;

namespace Api.Airbnb.Repository.Imp
{
    public class ImpHousingRepository : IHousingRepository
    {
        ChozadbContext _context;

        public ImpHousingRepository(ChozadbContext context)
        {
            _context = context;
        }


        public async Task<List<Housing>> GetAllHousings()
        {
            return _context.Housings.AsEnumerable<Housing>().ToList();
        }
    }
}
