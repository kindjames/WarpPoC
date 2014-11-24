using System;

namespace Warp.Data.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserRoleId { get; set; }
        public int NotificationCategoryId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string HyperlinkURL { get; set; }
        public string HyperlinkText { get; set; }
        public string DisplayOnActionMessage { get; set; }
        public bool HasBeenRead { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual NotificationCategory NotificationCategory { get; set; }
    }
}