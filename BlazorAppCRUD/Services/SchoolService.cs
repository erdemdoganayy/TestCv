using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class SchoolService : ISchoolService
    {
        private readonly IApplicationDbContext _db;

        public SchoolService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<School>> GetSchools()
        {
            return await _db.Schools.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
