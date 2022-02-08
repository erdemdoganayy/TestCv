using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class EducationService : IEducationService
    {
        private readonly IApplicationDbContext _db;

        public EducationService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Education>> GetEducation()
        {
            return await _db.Education.ToListAsync();
        }

        public async Task<bool> Create(Education education)
        {
            _db.Education.Add(education);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }


    }
}
