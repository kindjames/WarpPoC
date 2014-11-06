using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonTimeTracker
    {
        public int PersonTimeTrackerID { get; set; }
        public int PersonID { get; set; }
        public int TimeTrackerID { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}
