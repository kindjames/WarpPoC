using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class QuestionResult
    {
        public QuestionResult()
        {
            QuestionResultActions = new List<QuestionResultAction>();
            ReportProblemTrackings = new List<ReportProblemTracking>();
            ReportProblemTrackings1 = new List<ReportProblemTracking>();
        }

        public int QuestionResultId { get; set; }
        public int AssessmentId { get; set; }
        public int AssessorId { get; set; }
        public int QuestionnaireQuestionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public string Comment { get; set; }
        public decimal Score { get; set; }
        public int CheckedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual ICollection<QuestionResultAction> QuestionResultActions { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings { get; set; }
        public virtual ICollection<ReportProblemTracking> ReportProblemTrackings1 { get; set; }
    }
}