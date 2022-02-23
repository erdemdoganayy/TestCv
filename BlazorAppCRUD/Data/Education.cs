namespace BlazorAppCRUD.Data
{
    public class Education : AuditableEntity
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
