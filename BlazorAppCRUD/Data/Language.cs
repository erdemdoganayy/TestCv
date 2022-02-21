namespace BlazorAppCRUD.Data
{
    public class Language : AuditableEntity
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageRating { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
