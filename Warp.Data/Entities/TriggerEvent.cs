using System;

namespace Warp.Data.Entities
{
    public partial class TriggerEvent
    {
        public int TriggerEventId { get; set; }
        public Nullable<int> TriggerId { get; set; }
        public Nullable<int> EventId { get; set; }
        public Nullable<int> DelayTypeId { get; set; }
        public Nullable<int> DelayValue { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DelayType DelayType { get; set; }
        public virtual SubscriptionEvent SubscriptionEvent { get; set; }
        public virtual Trigger Trigger { get; set; }
    }
}
