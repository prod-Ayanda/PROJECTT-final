using System;

namespace PROJECTT.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateSent { get; set; }

        /// <summary>True once an admin has sent a reply.</summary>
        public bool IsReplied { get; set; }
        public string ReplyText { get; set; }
        public DateTime? RepliedAt { get; set; }
        public string RepliedBy { get; set; }
    }
}
