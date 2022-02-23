using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class LanguageService : ILanguageService
    {
        private readonly IApplicationDbContext _db;

        public LanguageService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Language>> GetLanguageName(int Id)
        {
            return await _db.Languages.Where(x => x.EmployeeId == Id).ToListAsync();
        }
        public async Task<bool> DeleteLanguage(int Id)
        {
            var language = await _db.Languages.FirstOrDefaultAsync(x => x.Id == Id);

            if (language != null)
            {
                _db.Languages.Remove(language);
                await _db.SaveChangesAsync(CancellationToken.None);
            }

            return true;
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
