using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class TriggerInstance
    {
        public TriggerInstance()
        {
            TriggerChecks = new List<TriggerCheck>();
            TriggerInstanceReports = new List<TriggerInstanceReport>();
        }

        public int TriggerInstanceId { get; set; }
        public int TriggerId { get; set; }
        public string Notes { get; set; }
        public DateTime? DateProcessStarted { get; set; }
        public DateTime? DateProcessEnded { get; set; }
        public DateTime DateTriggered { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Manual { get; set; }
        public bool ResendAll { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TriggerCheck> TriggerChecks { get; set; }
        public virtual ICollection<TriggerInstanceReport> TriggerInstanceReports { get; set; }
    }
}