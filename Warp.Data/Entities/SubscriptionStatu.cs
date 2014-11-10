using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SubscriptionStatu
    {
        public SubscriptionStatu()
        {
            this.Subscriptions = new List<Subscription>();
        }

        public int SubscriptionStatusId { get; set; }
        public Nullable<System.DateTime> ValidTill { get; set; }
        public int SubscriptionStatusTypeId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual SubscriptionStatusType SubscriptionStatusType { get; set; }
    }
}
