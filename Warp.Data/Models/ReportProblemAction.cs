using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemAction
    {
        public ReportProblemAction()
        {
            this.ReportProblemTrackingActions = new List<ReportProblemTrackingAction>();
        }

        public int ReportProblemActionID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short ReportProblemActionTypeID { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public int AddedByAdminID { get; set; }
        public virtual ReportProblemActionType ReportProblemActionType { get; set; }
        public virtual ICollection<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
    }
}
