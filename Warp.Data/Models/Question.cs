using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Question
    {
        public Question()
        {
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.QuestionPossibleAnswers = new List<QuestionPossibleAnswer>();
            this.QuestionTags = new List<QuestionTag>();
            this.QuestionTrackers = new List<QuestionTracker>();
            this.QuestionTrackers1 = new List<QuestionTracker>();
        }

        public int QuestionID { get; set; }
        public string Text { get; set; }
        public short QuestionTypeID { get; set; }
        public Nullable<int> DefaultQuestionSectionID { get; set; }
        public short DefaultManagementCategoryID { get; set; }
        public short DefaultBenchmarkID { get; set; }
        public short DefaultQuestionDepartmentID { get; set; }
        public string DefaultHint { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> TrackingQuestionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Benchmark Benchmark { get; set; }
        public virtual ManagementCategory ManagementCategory { get; set; }
        public virtual QuestionSection QuestionSection { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<QuestionPossibleAnswer> QuestionPossibleAnswers { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
        public virtual ICollection<QuestionTracker> QuestionTrackers { get; set; }
        public virtual ICollection<QuestionTracker> QuestionTrackers1 { get; set; }
    }
}
