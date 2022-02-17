using BlazorAppCRUD.Data;
using BlazorAppCRUD.Persistence;
using System.Data.Entity;

namespace BlazorAppCRUD.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IApplicationDbContext _db;

        public LanguageService(IApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> Create(Language language)
        {
            _db.Languages.Add(language);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }

        public async Task<List<Language>> GetLanguage()
        {
            return await _db.Languages.ToListAsync();
        }
    }
}
