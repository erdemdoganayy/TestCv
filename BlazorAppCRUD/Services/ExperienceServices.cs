using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class ExperienceServices : IExperienceServices
    {
        private readonly IApplicationDbContext _db;

        public ExperienceServices(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Experience>> GetExperience()
        {
            return await _db.Experiences.ToListAsync();
        }

        public async Task<bool> Create(Experience experience)
        {
            _db.Experiences.Add(experience);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }

    
    }
}
