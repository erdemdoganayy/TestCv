namespace BlazorAppCRUD.Data
{
    public interface IForgotPasswordService
    {
        Task<bool> Create(ForgotPassword forgotPassword);
        Task<ForgotPassword> GetUser(int Id);


    }
}
