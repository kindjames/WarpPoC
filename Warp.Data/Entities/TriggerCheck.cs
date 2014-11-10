using System;

namespace Warp.Data.Entities
{
    public partial class TriggerCheck
    {
        public int TriggerCheckId { get; set; }
        public int SubscriptionId { get; set; }
        public System.DateTime DateChecked { get; set; }
        public Nullable<int> TriggerInstanceId { get; set; }
        public bool Processed { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual TriggerInstance TriggerInstance { get; set; }
    }
}
