namespace BlazorAppCRUD.Data
{
    public interface ILanguageService
    {
        Task<List<Language>> GetLanguage();
        Task<bool> Create(Language language);
        Task<List<Language>> GetLanguageName(int Id);
        Task<bool> DeleteLanguage(int Id);
    }
}
