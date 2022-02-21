namespace BlazorAppCRUD.Data
{
    public class Language : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
