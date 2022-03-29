using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;


namespace BlazorAppCRUD.Data
{
    public class FeedBackService : IFeedBackService
    {
        private readonly IApplicationDbContext _db;

        public FeedBackService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(FeedBack feedBack)
        {
            _db.FeedBacks.Add(feedBack);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }
        public async Task<List<FeedBack>> GetFeedBacks(int Id)
        {
            return await _db.FeedBacks.Where(x => x.Id == Id).ToListAsync();
        }



    }
}

