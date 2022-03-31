namespace BlazorAppCRUD.Data
{
    public interface IUserService
    {
        Task<bool> Create(User user);
        Task<User> GetUser(int Id);
        Task<User> GetUserEmail(string Email);
        Task<User> GetUserPassword(string Password);
        Task<bool> Update(User objUser);
    }
}
