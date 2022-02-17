using BlazorAppCRUD.Data;

namespace BlazorAppCRUD.Services
{
    public interface ILanguageService
    {
        Task<List<Language>> GetLanguage();
        Task<bool> Create(Language language);
    }
}
