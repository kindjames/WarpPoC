using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionResult
    {
        public QuestionResult()
        {
            this.QuestionResultActions = new List<QuestionResultAction>();
            this.ReportProblemTrackings = new List<ReportProblemTracking>();
            this.ReportProblemTrackings1 = new List<ReportProblemTracking>();
        }

        public int QuestionResultID { get; set; }
        public int AssessmentID { get; set; }
        public int AssessorID { get; set; }
        public int QuestionnaireQuestionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public string Comment { get; set; }
        public decimal Score { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int CheckedByAdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual ICollection<QuestionResultAction> QuestionResultActions { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings1 { get; set; }
    }
}
