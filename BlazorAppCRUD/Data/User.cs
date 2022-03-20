namespace BlazorAppCRUD.Data
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordOne { get; set; }
        public string PasswordTwo { get; set; }

    }
}
