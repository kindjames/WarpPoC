using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportProblemTracking
    {
        public ReportProblemTracking()
        {
            this.ReportProblemTrackingActions = new List<ReportProblemTrackingAction>();
        }

        public int ReportProblemTrackingID { get; set; }
        public int QuestionResultID { get; set; }
        public short ReportProblemCauseID { get; set; }
        public short ReportProblemTypeID { get; set; }
        public int DetectedByAdminID { get; set; }
        public bool Resolved { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CreatedQuestionResultID { get; set; }
        public virtual QuestionResult QuestionResult { get; set; }
        public virtual QuestionResult QuestionResult1 { get; set; }
        public virtual ReportProblemCause ReportProblemCause { get; set; }
        public virtual ReportProblemType ReportProblemType { get; set; }
        public virtual ICollection<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
    }
}
