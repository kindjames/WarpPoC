using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TimeTrackerType
    {
        public TimeTrackerType()
        {
            this.TimeTrackers = new List<TimeTracker>();
        }

        public short TimeTrackerTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TimeTracker> TimeTrackers { get; set; }
    }
}
