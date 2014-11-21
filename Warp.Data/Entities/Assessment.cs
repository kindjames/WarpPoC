using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Assessment
    {
        public Assessment()
        {
            QuestionResults = new List<QuestionResult>();
            ResultComments = new List<ResultComment>();
            TelephoneRecordings = new List<TelephoneRecording>();
        }

        public int AssessmentId { get; set; }
        public int VisitId { get; set; }
        public short AssessmentAreaId { get; set; }
        public int QuestionnaireId { get; set; }
        public int SubQuestionnaireId { get; set; }
        public int BriefId { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public int LastUpdatedAdminId { get; set; }
        public double? Score { get; set; }
        public double? MaxScore { get; set; }
        public DateTime? DateScoreCalculated { get; set; }
        public bool Invoiced { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual AssessmentArea AssessmentArea { get; set; }
        public virtual Brief Brief { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual ICollection<QuestionResult> QuestionResults { get; set; }
        public virtual ICollection<ResultComment> ResultComments { get; set; }
        public virtual ICollection<TelephoneRecording> TelephoneRecordings { get; set; }
    }
}