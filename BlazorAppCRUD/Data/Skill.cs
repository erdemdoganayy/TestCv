namespace BlazorAppCRUD.Data
{
    public class Skill : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string ShortInfo { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
