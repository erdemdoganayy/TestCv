using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class SchoolDepartmentService : ISchoolDepartmentService
    {
        private readonly IApplicationDbContext _db;

        public SchoolDepartmentService(IApplicationDbContext db)
        {
            _db = db;
        }

     
        public async Task<List<SchoolDepartment>> GetDepartments()
        {
            return await _db.SchoolDepartments.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
