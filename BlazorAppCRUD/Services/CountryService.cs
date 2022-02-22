using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class CountryService : ICountryService
    {
        private readonly IApplicationDbContext _db;

        public CountryService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Country>> GetCountries()
        {
            return await _db.Countries.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
