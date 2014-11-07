using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SubscriptionEventType
    {
        public SubscriptionEventType()
        {
            this.SubscriptionEvents = new List<SubscriptionEvent>();
        }

        public int SubscriptionEventTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionEvent> SubscriptionEvents { get; set; }
    }
}
