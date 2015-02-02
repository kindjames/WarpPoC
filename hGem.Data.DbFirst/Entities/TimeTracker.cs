using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class TimeTracker
    {
        public TimeTracker()
        {
            AssessorTimeTrackers = new List<AssessorTimeTracker>();
            PersonTimeTrackers = new List<PersonTimeTracker>();
            VisitTimeTrackers = new List<VisitTimeTracker>();
        }

        public int TimeTrackerId { get; set; }
        public int AdminId { get; set; }
        public short TimeTrackerTypeId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorTimeTracker> AssessorTimeTrackers { get; set; }
        public virtual ICollection<PersonTimeTracker> PersonTimeTrackers { get; set; }
        public virtual TimeTrackerType TimeTrackerType { get; set; }
        public virtual ICollection<VisitTimeTracker> VisitTimeTrackers { get; set; }
    }
}