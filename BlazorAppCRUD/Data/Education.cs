namespace BlazorAppCRUD.Data
{
    public class Education
    {
        public int Id { get; set; }

        public string School { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
