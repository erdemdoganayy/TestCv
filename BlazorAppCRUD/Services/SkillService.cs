using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class SkillService : ISkillService
    {

        private readonly IApplicationDbContext _db;

        public SkillService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Skill>> GetSkillName(int Id)
        {
            return await _db.Skills.Where(x => x.EmployeeId == Id).ToListAsync();
        }
        public async Task<bool> DeleteSkill(int Id)
        {
            var skill = await _db.Skills.FirstOrDefaultAsync(x => x.Id == Id);

            if (skill != null)
            {
                _db.Skills.Remove(skill);
                await _db.SaveChangesAsync(CancellationToken.None);
            }

            return true;
        }

        public async Task<bool> Create(Skill skill)
        {
             _db.Skills.Add(skill);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;

        }

        public async Task<List<Skill>> GetSkill()
        {
            return await _db.Skills.ToListAsync();
        }
    }
}
