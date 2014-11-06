using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionnaireQuestion
    {
        public QuestionnaireQuestion()
        {
            this.DynamicQuestions = new List<DynamicQuestion>();
            this.DynamicQuestions1 = new List<DynamicQuestion>();
            this.QuestionnaireQuestionPossibleAnswers = new List<QuestionnaireQuestionPossibleAnswer>();
            this.QuestionResults = new List<QuestionResult>();
            this.SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int QuestionnaireQuestionID { get; set; }
        public int QuestionnaireID { get; set; }
        public int QuestionSectionID { get; set; }
        public byte SectionNumber { get; set; }
        public int QuestionID { get; set; }
        public string QuestionOverwriteText { get; set; }
        public string QuestionOverwriteHint { get; set; }
        public short QuestionNumber { get; set; }
        public short ManagementCategoryID { get; set; }
        public short BenchmarkID { get; set; }
        public short QuestionDepartmentID { get; set; }
        public decimal MaxScore { get; set; }
        public byte MinAnswer { get; set; }
        public byte MaxAnswer { get; set; }
        public bool Dynamic { get; set; }
        public string Hint { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateActive { get; set; }
        public short AddedByAdminID { get; set; }
        public virtual Benchmark Benchmark { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions { get; set; }
        public virtual ICollection<DynamicQuestion> DynamicQuestions1 { get; set; }
        public virtual ManagementCategory ManagementCategory { get; set; }
        public virtual Question Question { get; set; }
        public virtual QuestionDepartment QuestionDepartment { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual QuestionSection QuestionSection { get; set; }
        public virtual ICollection<QuestionnaireQuestionPossibleAnswer> QuestionnaireQuestionPossibleAnswers { get; set; }
        public virtual ICollection<QuestionResult> QuestionResults { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
