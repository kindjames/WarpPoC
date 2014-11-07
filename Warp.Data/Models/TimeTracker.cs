using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TimeTracker
    {
        public TimeTracker()
        {
            this.AssessorTimeTrackers = new List<AssessorTimeTracker>();
            this.PersonTimeTrackers = new List<PersonTimeTracker>();
            this.VisitTimeTrackers = new List<VisitTimeTracker>();
        }

        public int TimeTrackerID { get; set; }
        public int AdminID { get; set; }
        public short TimeTrackerTypeID { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorTimeTracker> AssessorTimeTrackers { get; set; }
        public virtual ICollection<PersonTimeTracker> PersonTimeTrackers { get; set; }
        public virtual TimeTrackerType TimeTrackerType { get; set; }
        public virtual ICollection<VisitTimeTracker> VisitTimeTrackers { get; set; }
    }
}
