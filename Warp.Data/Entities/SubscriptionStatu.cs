using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SubscriptionStatu
    {
        public SubscriptionStatu()
        {
            Subscriptions = new List<Subscription>();
        }

        public int SubscriptionStatusId { get; set; }
        public DateTime? ValidTill { get; set; }
        public int SubscriptionStatusTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual SubscriptionStatusType SubscriptionStatusType { get; set; }
    }
}