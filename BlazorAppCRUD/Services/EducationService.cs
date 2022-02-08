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
            return await _db.Educations.ToListAsync();
        }

        public async Task<bool> Create(Education education)
        {
            _db.Educations.Add(education);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }


    }
}
