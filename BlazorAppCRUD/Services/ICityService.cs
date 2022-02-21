namespace BlazorAppCRUD.Data
{
    public interface ICityService
    {
        Task<List<City>> GetCities();
    }
}
