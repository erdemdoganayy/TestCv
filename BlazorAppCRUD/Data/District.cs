namespace BlazorAppCRUD.Data
{
    public class District
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
