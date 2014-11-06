using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorTimeTracker
    {
        public int AssessorTimeTrackerID { get; set; }
        public int AssessorID { get; set; }
        public int TimeTrackerID { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual TimeTracker TimeTracker { get; set; }
    }
}
