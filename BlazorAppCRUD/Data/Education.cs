namespace BlazorAppCRUD.Data
{
    public class Education
    {
        public int EducationId { get; set; }
        public string School { get; set; }

        public int EmployeeId { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }
    }
}
