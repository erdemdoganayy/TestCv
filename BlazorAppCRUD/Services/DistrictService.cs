using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;


namespace BlazorAppCRUD.Data
{
    public class DistrictService : IDistrictService
    {
        private readonly IApplicationDbContext _db;

        public DistrictService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<District>> GetDistricts(int EmployeeCityId)
        {
            return await _db.Districts.Where(x => x.CityId == EmployeeCityId).OrderBy(x => x.Name).ToListAsync();
        }
    }
}
