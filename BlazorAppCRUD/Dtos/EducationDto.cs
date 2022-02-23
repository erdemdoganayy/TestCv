namespace BlazorAppCRUD.Dtos
{
    public class EducationDto
    {
        public int SchoolId { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
