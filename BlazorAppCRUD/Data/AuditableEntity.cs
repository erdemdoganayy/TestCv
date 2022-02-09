namespace BlazorAppCRUD.Data
{
    public abstract class AuditableEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

    }
}
