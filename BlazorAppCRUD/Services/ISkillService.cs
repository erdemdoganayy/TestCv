using BlazorAppCRUD.Data;

namespace BlazorAppCRUD.Services
{
    public interface ISkillService
    {
        Task<List<Skill>> GetSkill();
        Task<bool> Create(Skill skill);
    }
}
