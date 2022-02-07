namespace BlazorAppCRUD.Data
{
    public interface IEmployeeService
    {
        Task<List<EmployeeInfo>> GetEmployee();
        Task<bool> Create(EmployeeInfo objEmployee);
    }
}