﻿namespace BlazorAppCRUD.Data
{
    public class FeedBack : AuditableEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
