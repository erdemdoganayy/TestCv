namespace BlazorAppCRUD.Data
{
    public interface IExperienceServices
    {
        Task<List<Experience>> GetExperience();
        Task<bool> Create(Experience experience);
        Task<bool> DeleteExperience(int Id);
        Task<List<Experience>> GetExperienceCompanyName(int Id);
    }
}
