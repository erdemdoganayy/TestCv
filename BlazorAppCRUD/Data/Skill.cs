namespace BlazorAppCRUD.Data
{
    public class Skill : AuditableEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int SkillRating { get; set; }
        public int SkillExperience { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
    }
}
