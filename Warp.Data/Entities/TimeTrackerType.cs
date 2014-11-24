using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class TimeTrackerType
    {
        public TimeTrackerType()
        {
            TimeTrackers = new List<TimeTracker>();
        }

        public short TimeTrackerTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TimeTracker> TimeTrackers { get; set; }
    }
}