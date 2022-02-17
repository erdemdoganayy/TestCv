namespace BlazorAppCRUD.Data
{
    public interface IEducationService
    {
        Task<List<Education>> GetEducation();
        Task<bool> Create(Education education);

        Task<List<Education>> GetEducationSchool(int Id);
        Task<bool> DeleteEducation(int Id);
    }
}
