namespace BlazorAppCRUD.Dtos
{
    public class ExperienceDto
    {
        public string ExperienceCompanyName { get; set; }
        public string ExperiencePosition { get; set; }
        public int ExperienceCityId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
