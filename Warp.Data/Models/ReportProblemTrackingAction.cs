using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemTrackingAction
    {
        public int ReportProblemTrackingActionID { get; set; }
        public int ReportProblemTrackingID { get; set; }
        public int ReportProblemActionID { get; set; }
        public virtual ReportProblemAction ReportProblemAction { get; set; }
        public virtual ReportProblemTracking ReportProblemTracking { get; set; }
    }
}
