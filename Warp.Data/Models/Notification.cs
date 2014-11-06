using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public int UserRoleID { get; set; }
        public int NotificationCategoryID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string HyperlinkURL { get; set; }
        public string HyperlinkText { get; set; }
        public string DisplayOnActionMessage { get; set; }
        public bool HasBeenRead { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public bool Active { get; set; }
        public virtual NotificationCategory NotificationCategory { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
