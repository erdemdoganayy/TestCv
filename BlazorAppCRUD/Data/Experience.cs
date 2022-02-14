namespace BlazorAppCRUD.Data
{
    public class Experience : AuditableEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public int startDate { get; set; }
        public int endDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
    }
}
