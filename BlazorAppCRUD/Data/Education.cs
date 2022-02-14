namespace BlazorAppCRUD.Data
{
    public class Education : AuditableEntity
    {
        public int Id { get; set; }

        public string School { get; set; }
        public string Department { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
