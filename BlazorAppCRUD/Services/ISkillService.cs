
namespace BlazorAppCRUD.Data
{
    public interface ISkillService
    {
        Task<List<Skill>> GetSkill();
        Task<bool> Create(Skill skill);
        Task<List<Skill>> GetSkillName(int Id);
        Task<bool> DeleteSkill(int Id);
    }
}
