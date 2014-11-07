using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SubscriptionDestination
    {
        public int SubscriptionDestinationId { get; set; }
        public Nullable<int> SubscriptionId { get; set; }
        public Nullable<int> DestinationId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
