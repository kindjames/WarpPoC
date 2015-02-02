using System;

namespace Warp.Data.DbFirst.Entities
{
    public class SubscriptionDestination
    {
        public int SubscriptionDestinationId { get; set; }
        public int? SubscriptionId { get; set; }
        public int? DestinationId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}