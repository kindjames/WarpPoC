using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Subscription
    {
        public Subscription()
        {
            SubscriptionDestinations = new List<SubscriptionDestination>();
            SubscriptionReports = new List<SubscriptionReport>();
            TriggerChecks = new List<TriggerCheck>();
        }

        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ClientId { get; set; }
        public int? Owner { get; set; }
        public int? TriggerId { get; set; }
        public int? SubscriptionStatusId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual SubscriptionStatu SubscriptionStatu { get; set; }
        public virtual Trigger Trigger { get; set; }
        public virtual ICollection<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public virtual ICollection<SubscriptionReport> SubscriptionReports { get; set; }
        public virtual ICollection<TriggerCheck> TriggerChecks { get; set; }
    }
}