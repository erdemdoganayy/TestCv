namespace BlazorAppCRUD.Data
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<bool> Create(Employee objEmployee);
        Task<bool> Update(Employee objEmployee);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> GetLastEmployee(int Id);
    }
}