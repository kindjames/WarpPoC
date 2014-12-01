using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Trigger
    {
        public Trigger()
        {
            Subscriptions = new List<Subscription>();
            TriggerEvents = new List<TriggerEvent>();
            TriggerHistories = new List<TriggerHistory>();
        }

        public int TriggerId { get; set; }
        public int? ScheduleId { get; set; }
        public string TriggerName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public DateTime TriggerTime { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<TriggerEvent> TriggerEvents { get; set; }
        public virtual ICollection<TriggerHistory> TriggerHistories { get; set; }
    }
}