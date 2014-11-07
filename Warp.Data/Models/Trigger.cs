using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Trigger
    {
        public Trigger()
        {
            this.Subscriptions = new List<Subscription>();
            this.TriggerEvents = new List<TriggerEvent>();
            this.TriggerHistories = new List<TriggerHistory>();
        }

        public int TriggerId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public string TriggerName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public System.DateTime TriggerTime { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
        public virtual ICollection<TriggerHistory> TriggerHistories { get; set; }
    }
}
