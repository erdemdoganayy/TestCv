
namespace BlazorAppCRUD.Data
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries();
    }
}
