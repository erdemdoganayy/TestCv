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
        public async Task<List<Experience>> GetExperienceCompanyName(int Id)
        {
            return await _db.Experiences.Where(x => x.EmployeeId == Id).ToListAsync();
        }
        public async Task<bool> DeleteExperience(int Id)
        {
            var experience = await _db.Experiences.FirstOrDefaultAsync(x => x.Id == Id);

            if (experience != null)
            {
                _db.Experiences.Remove(experience);
                await _db.SaveChangesAsync(CancellationToken.None);
            }

            return true;
        }

        public async Task<bool> Create(Experience experience)
        {
            _db.Experiences.Add(experience);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }

    
    }
}
