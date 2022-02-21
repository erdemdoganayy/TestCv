namespace BlazorAppCRUD.Data
{
    public class City
    {
        public City()
        {
            Districts = new List<District>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }

        public List<District> Districts { get; set; }
    }
}
