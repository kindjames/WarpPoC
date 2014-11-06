using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitTimeTracker
    {
        public int VisitTimeTrackerID { get; set; }
        public int VisitID { get; set; }
        public int TimeTrackerID { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
