using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApplicationDbContext _db;

        public EmployeeService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<EmployeeInfo>> GetEmployee()
        {
            return await _db.Employees.ToListAsync();
        }

        public async Task<bool> Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }
    }
}
