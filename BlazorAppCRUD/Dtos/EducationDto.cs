namespace BlazorAppCRUD.Dtos
{
    public class EducationDto
    {
        public string EducationSchool { get; set; }
        public string EducationDepartment { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
