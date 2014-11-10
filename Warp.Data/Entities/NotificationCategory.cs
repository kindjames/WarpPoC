using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class NotificationCategory
    {
        public NotificationCategory()
        {
            this.Notifications = new List<Notification>();
        }

        public int NotificationCategoryID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
