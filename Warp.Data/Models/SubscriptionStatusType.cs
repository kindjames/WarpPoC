using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SubscriptionStatusType
    {
        public SubscriptionStatusType()
        {
            this.SubscriptionStatus = new List<SubscriptionStatu>();
        }

        public int SubscriptionStatusTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubscriptionStatu> SubscriptionStatus { get; set; }
    }
}
