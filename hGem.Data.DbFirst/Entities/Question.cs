using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Question
    {
        public Question()
        {
            QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            QuestionPossibleAnswers = new List<QuestionPossibleAnswer>();
            QuestionTags = new List<QuestionTag>();
            QuestionTrackers = new List<QuestionTracker>();
            QuestionTrackers1 = new List<QuestionTracker>();
        }

        public int QuestionId { get; set; }
        public string Text { get; set; }
        public short QuestionTypeId { get; set; }
        public int? DefaultQuestionSectionId { get; set; }
        public short DefaultManagementCategoryId { get; set; }
        public short DefaultBenchmarkId { get; set; }
        public short DefaultQuestionDepartmentId { get; set; }
        public string DefaultHint { get; set; }
        public int? ClientId { get; set; }
        public int? TrackingQuestionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
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