namespace BlazorAppCRUD.Data
{
    public class ForgotPassword : AuditableEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Guid Token { get; set; }
    }
}
