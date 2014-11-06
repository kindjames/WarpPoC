using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerTimeTracker
    {
        public int ManagerTimeTrackerID { get; set; }
        public int ManagerID { get; set; }
        public int TimeTrackerID { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}
