using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Assessment
    {
        public Assessment()
        {
            this.QuestionResults = new List<QuestionResult>();
            this.ResultComments = new List<ResultComment>();
            this.TelephoneRecordings = new List<TelephoneRecording>();
        }

        public int AssessmentID { get; set; }
        public int VisitID { get; set; }
        public short AssessmentAreaID { get; set; }
        public int QuestionnaireID { get; set; }
        public int SubQuestionnaireID { get; set; }
        public int BriefID { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int LastUpdatedAdminID { get; set; }
        public Nullable<double> Score { get; set; }
        public Nullable<double> MaxScore { get; set; }
        public Nullable<System.DateTime> DateScoreCalculated { get; set; }
        public bool Invoiced { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
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
