using System;

namespace Warp.Data.Entities
{
    public class TriggerCheck
    {
        public int TriggerCheckId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime DateChecked { get; set; }
        public int? TriggerInstanceId { get; set; }
        public bool Processed { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual TriggerInstance TriggerInstance { get; set; }
    }
}