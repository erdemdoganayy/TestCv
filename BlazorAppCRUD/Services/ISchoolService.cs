namespace BlazorAppCRUD.Data
{
    public interface ISchoolService
    {
        Task<List<School>> GetSchools();
    }
}
