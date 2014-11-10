using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class TriggerInstance
    {
        public TriggerInstance()
        {
            this.TriggerChecks = new List<TriggerCheck>();
            this.TriggerInstanceReports = new List<TriggerInstanceReport>();
        }

        public int TriggerInstanceId { get; set; }
        public int TriggerId { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateProcessStarted { get; set; }
        public Nullable<System.DateTime> DateProcessEnded { get; set; }
        public System.DateTime DateTriggered { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Manual { get; set; }
        public bool ResendAll { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TriggerCheck> TriggerChecks { get; set; }
        public virtual ICollection<TriggerInstanceReport> TriggerInstanceReports { get; set; }
    }
}
