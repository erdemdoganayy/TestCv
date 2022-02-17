namespace BlazorAppCRUD.Data
{
    public class Experience : AuditableEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
