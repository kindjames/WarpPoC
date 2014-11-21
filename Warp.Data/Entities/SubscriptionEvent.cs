using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SubscriptionEvent
    {
        public SubscriptionEvent()
        {
            TriggerEvents = new List<TriggerEvent>();
        }

        public int SubscriptionEventId { get; set; }
        public int SubscriptionEventTypeId { get; set; }
        public string EventName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual SubscriptionEventType SubscriptionEventType { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
    }
}