using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public int CheckedByAdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual ICollection<QuestionResultAction> QuestionResultActions { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings1 { get; set; }
    }
}
