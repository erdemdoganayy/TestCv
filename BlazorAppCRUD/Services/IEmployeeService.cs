namespace BlazorAppCRUD.Data
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<bool> Create(Employee objEmployee);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> GetLastEmployees(int Id);
    }
}