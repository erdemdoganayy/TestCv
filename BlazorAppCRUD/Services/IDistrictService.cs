namespace BlazorAppCRUD.Data
{
    public interface IDistrictService
    {
        Task<List<District>> GetDistricts(int EmployeeCityId);
    }
}
