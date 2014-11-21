using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SubscriptionStatusType
    {
        public SubscriptionStatusType()
        {
            SubscriptionStatus = new List<SubscriptionStatu>();
        }

        public int SubscriptionStatusTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionStatu> SubscriptionStatus { get; set; }
    }
}