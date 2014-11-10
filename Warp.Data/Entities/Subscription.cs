using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Subscription
    {
        public Subscription()
        {
            this.SubscriptionDestinations = new List<SubscriptionDestination>();
            this.SubscriptionReports = new List<SubscriptionReport>();
            this.TriggerChecks = new List<TriggerCheck>();
        }

        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> Owner { get; set; }
        public Nullable<int> TriggerId { get; set; }
        public Nullable<int> SubscriptionStatusId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual SubscriptionStatu SubscriptionStatu { get; set; }
        public virtual Trigger Trigger { get; set; }
        public virtual ICollection<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public virtual ICollection<SubscriptionReport> SubscriptionReports { get; set; }
        public virtual ICollection<TriggerCheck> TriggerChecks { get; set; }
    }
}
