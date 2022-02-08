namespace BlazorAppCRUD.Data
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployee();
        Task<bool> Create(Employee objEmployee);
    }
}