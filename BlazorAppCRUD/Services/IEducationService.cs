namespace BlazorAppCRUD.Data
{
    public interface IEducationService
    {
        Task<List<Education>> GetEducation();
        Task<bool> Create(Education education);
    }
}
