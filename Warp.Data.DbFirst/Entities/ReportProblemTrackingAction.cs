using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportProblemTrackingAction
    {
        public int ReportProblemTrackingActionId { get; set; }
        public int ReportProblemTrackingId { get; set; }
        public int ReportProblemActionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ReportProblemAction ReportProblemAction { get; set; }
        public virtual ReportProblemTracking ReportProblemTracking { get; set; }
    }
}