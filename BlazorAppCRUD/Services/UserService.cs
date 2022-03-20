using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbContext _db;

        public UserService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }

        public async Task<User> GetUser(int Id)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<User> GetUserEmail(string Email)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Email == Email);
        }
        public async Task<User> GetUserPassword(string Password)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.PasswordOne == Password);
        }


    }
}
