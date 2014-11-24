using System;

namespace Warp.Data.Entities
{
    public class TriggerEvent
    {
        public int TriggerEventId { get; set; }
        public int? TriggerId { get; set; }
        public int? EventId { get; set; }
        public int? DelayTypeId { get; set; }
        public int? DelayValue { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual DelayType DelayType { get; set; }
        public virtual SubscriptionEvent SubscriptionEvent { get; set; }
        public virtual Trigger Trigger { get; set; }
    }
}