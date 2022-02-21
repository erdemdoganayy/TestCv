namespace BlazorAppCRUD.Data
{
    public class Experience : AuditableEntity
    {
        public int ExperienceId { get; set; }
        public string ExperienceCompanyName { get; set; }
        public string ExperiencePosition { get; set; }
        public int ExperienceCityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
