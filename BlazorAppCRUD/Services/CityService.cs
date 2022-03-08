using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class CityService : ICityService
    {
        private readonly IApplicationDbContext _db;

        public CityService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<City>> GetCities()
        {
            return await _db.Cities.OrderBy(x=>x.Name).ToListAsync();
        }

        public async Task<List<City>> GetSelectedCities(int EmployeeCountryId)
        {
            return await _db.Cities.Where(x => x.CountryId == EmployeeCountryId).OrderBy(x => x.Name).ToListAsync();
        }
    }
}
