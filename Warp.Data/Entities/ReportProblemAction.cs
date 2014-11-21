using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ReportProblemAction
    {
        public ReportProblemAction()
        {
            ReportProblemTrackingActions = new List<ReportProblemTrackingAction>();
        }

        public int ReportProblemActionId { get; set; }
        public short ReportProblemActionTypeId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ReportProblemActionType ReportProblemActionType { get; set; }
        public virtual ICollection<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
    }
}