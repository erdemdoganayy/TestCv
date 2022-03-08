namespace BlazorAppCRUD.Data
{
    public interface ICityService
    {
        Task<List<City>> GetCities();
        Task<List<City>> GetSelectedCities(int EmployeeCountryId);
    }
}
