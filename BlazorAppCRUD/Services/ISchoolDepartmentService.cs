namespace BlazorAppCRUD.Data
{
    public interface ISchoolDepartmentService
    {
        Task<List<SchoolDepartment>> GetDepartments();
    }
}
