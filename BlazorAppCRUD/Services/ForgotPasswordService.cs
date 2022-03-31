
using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly IApplicationDbContext _db;

        public ForgotPasswordService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(ForgotPassword forgotPassword)
        {
            _db.ForgotPasswords.Add(forgotPassword);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }
        public async Task<ForgotPassword> GetUser(int Id)
        {
            return await _db.ForgotPasswords.OrderByDescending(x => x.Id).FirstOrDefaultAsync(x => x.UserId == Id);
        }

    
    }
}
