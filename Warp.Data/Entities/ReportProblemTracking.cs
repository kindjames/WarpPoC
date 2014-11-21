using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ReportProblemTracking
    {
        public ReportProblemTracking()
        {
            ReportProblemTrackingActions = new List<ReportProblemTrackingAction>();
        }

        public int ReportProblemTrackingId { get; set; }
        public int QuestionResultId { get; set; }
        public short ReportProblemCauseId { get; set; }
        public short ReportProblemTypeId { get; set; }
        public int DetectedByAdminId { get; set; }
        public bool Resolved { get; set; }
        public string Notes { get; set; }
        public int? CreatedQuestionResultId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual QuestionResult QuestionResult { get; set; }
        public virtual QuestionResult QuestionResult1 { get; set; }
        public virtual ReportProblemCause ReportProblemCause { get; set; }
        public virtual ReportProblemType ReportProblemType { get; set; }
        public virtual ICollection<ReportProblemTrackingAction> ReportProblemTrackingActions { get; set; }
    }
}