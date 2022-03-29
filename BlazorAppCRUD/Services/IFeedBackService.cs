namespace BlazorAppCRUD.Data
{
    public interface IFeedBackService
    {
        Task<bool> Create(FeedBack feedBack);
        Task<List<FeedBack>> GetFeedBacks(int Id);
       
    }
}
