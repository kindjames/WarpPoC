using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class SubscriptionEventType
    {
        public SubscriptionEventType()
        {
            SubscriptionEvents = new List<SubscriptionEvent>();
        }

        public int SubscriptionEventTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionEvent> SubscriptionEvents { get; set; }
    }
}