namespace BlazorAppCRUD.Data
{
    public class City
    {
        public City()
        {
            Districts = new List<District>();
        }

        public int Id { get; set; }
        public int CitiesId { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<District> Districts { get; set; }
    }
}
