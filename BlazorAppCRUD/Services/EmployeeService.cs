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
            List<City> cityList = new List<City>();
            return await _db.Employees.ToListAsync();
        }
        //.Include(e => e.City)
        // Where(x=>x.EmployeeCityId == cityList.)
        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _db.Employees.FirstOrDefaultAsync(x => x.EmployeeEmail == email);
        }

        public async Task<bool> Create(Employee objEmployee)
        {
            var employee = _db.Employees.FirstOrDefault(x => x.EmployeeEmail == objEmployee.EmployeeEmail);
            if (employee == null)
            {
                _db.Employees.Add(objEmployee);
                await _db.SaveChangesAsync(CancellationToken.None);
                return true;
            }
            else
            {
                employee.EmployeeGender = objEmployee.EmployeeGender;
                employee.EmployeeEmail = objEmployee.EmployeeEmail;
                employee.EmployeeAge = objEmployee.EmployeeAge;
                employee.EmployeeVillage = objEmployee.EmployeeVillage;
                employee.EmployeeCityId = Convert.ToInt32(objEmployee.EmployeeCityId);
                employee.EmployeeCountry = objEmployee.EmployeeCountry;

                _db.Employees.Update(employee);
                await _db.SaveChangesAsync(CancellationToken.None);

                return true;
            }

            return false;
        }
    }
}
