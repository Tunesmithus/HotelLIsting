using HotelLIsting.API.Contracts;
using HotelLIsting.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelLIsting.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            var record = _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(h => h.Id == id);


            return await record;
        }
    }
}
