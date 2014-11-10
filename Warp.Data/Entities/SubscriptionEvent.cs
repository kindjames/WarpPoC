using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SubscriptionEvent
    {
        public SubscriptionEvent()
        {
            this.TriggerEvents = new List<TriggerEvent>();
        }

        public int SubscriptionEventId { get; set; }
        public int SubscriptionEventTypeId { get; set; }
        public string EventName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual SubscriptionEventType SubscriptionEventType { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
    }
}
