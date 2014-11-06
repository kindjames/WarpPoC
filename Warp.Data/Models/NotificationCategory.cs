using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class NotificationCategory
    {
        public NotificationCategory()
        {
            this.Notifications = new List<Notification>();
        }

        public int NotificationCategoryID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
