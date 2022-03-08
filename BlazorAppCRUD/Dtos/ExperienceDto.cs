namespace BlazorAppCRUD.Dtos
{
    public class ExperienceDto
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string BriefInformation { get; set; }
        public int CountryId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
