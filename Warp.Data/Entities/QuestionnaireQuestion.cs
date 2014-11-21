using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class QuestionnaireQuestion
    {
        public QuestionnaireQuestion()
        {
            DynamicQuestions = new List<DynamicQuestion>();
            DynamicQuestions1 = new List<DynamicQuestion>();
            QuestionnaireQuestionPossibleAnswers = new List<QuestionnaireQuestionPossibleAnswer>();
            QuestionResults = new List<QuestionResult>();
            SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
            SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int QuestionnaireQuestionId { get; set; }
        public int QuestionnaireId { get; set; }
        public int QuestionSectionId { get; set; }
        public byte SectionNumber { get; set; }
        public int QuestionId { get; set; }
        public string QuestionOverwriteText { get; set; }
        public string QuestionOverwriteHint { get; set; }
        public short QuestionNumber { get; set; }
        public short ManagementCategoryId { get; set; }
        public short BenchmarkId { get; set; }
        public short QuestionDepartmentId { get; set; }
        public decimal MaxScore { get; set; }
        public byte MinAnswer { get; set; }
        public byte MaxAnswer { get; set; }
        public bool Dynamic { get; set; }
        public string Hint { get; set; }
        public DateTime DateCreated { get; set; }
        public short AddedByAdminId { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Benchmark Benchmark { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions1 { get; set; }
        public virtual ManagementCategory ManagementCategory { get; set; }
        public virtual Question Question { get; set; }
        public virtual QuestionDepartment QuestionDepartment { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual QuestionSection QuestionSection { get; set; }

        public virtual ICollection<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set;
        }

        public virtual ICollection<QuestionResult> QuestionResults { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}