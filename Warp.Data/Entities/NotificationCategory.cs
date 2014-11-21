using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class NotificationCategory
    {
        public NotificationCategory()
        {
            Notifications = new List<Notification>();
        }

        public int NotificationCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}