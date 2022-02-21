namespace BlazorAppCRUD.Data
{
    public class Skill : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int Experience { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
