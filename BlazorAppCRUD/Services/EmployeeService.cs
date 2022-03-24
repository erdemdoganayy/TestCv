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

        public async Task<List<Employee>> GetEmployees()
        {
            return await _db.Employees
                .Include(x => x.Country)
                .Include(x => x.Experiences)
                .Include(x => x.Educations)
                .Include(x => x.Languages)
                .Include(x => x.Skills)
                .Include(x => x.District)
                .ThenInclude(x => x.City)
                .ToListAsync();
        }
        public async Task<Employee> GetLastEmployee(int Id)
        {
            return await _db.Employees.FirstOrDefaultAsync(x => x.Id == Id);
        }
        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _db.Employees.FirstOrDefaultAsync(x => x.Email == email.Trim());
        }

        public async Task<bool> Create(Employee objEmployee)
        {
            _db.Employees.Add(objEmployee);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
     
        }
        public async Task<bool> Update(Employee objEmployee)
        {
            var employee = _db.Employees.FirstOrDefault(x => x.Id == objEmployee.Id);
            if (employee != null)
            {
                _db.Employees.Update(objEmployee);
                await _db.SaveChangesAsync(CancellationToken.None);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
