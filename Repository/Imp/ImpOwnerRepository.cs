using Api.Airbnb.DBContext;
using Api.Airbnb.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Airbnb.Repository.Imp
{
    public class ImpOwnerRepository : IOwnerRepository
    {
        ChozadbContext _context;


        public ImpOwnerRepository(ChozadbContext context)
        {
            _context = context;
        }

        public Task<List<Owner>> GetAllOwners()
        {
            return _context.Owner.ToListAsync();
        }
    }
}
