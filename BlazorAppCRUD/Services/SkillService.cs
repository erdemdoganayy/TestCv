using BlazorAppCRUD.Data;
using BlazorAppCRUD.Persistence;
using System.Data.Entity;

namespace BlazorAppCRUD.Services
{
    public class SkillService : ISkillService
    {

        private readonly IApplicationDbContext _db;

        public SkillService(IApplicationDbContext db)
        {
            _db = db;
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
