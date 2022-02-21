namespace BlazorAppCRUD.Data
{
    public class Education : AuditableEntity
    {
        public int EducationId { get; set; }

        public string EducationSchool { get; set; }
        public string EducationDepartment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
