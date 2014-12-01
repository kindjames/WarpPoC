using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class SubQuestionnaireQuestionOverwrite
    {
        public SubQuestionnaireQuestionOverwrite()
        {
            SQQOPossibleAnswers = new List<SQQOPossibleAnswer>();
            SubDynamicQuestions = new List<SubDynamicQuestion>();
            SubDynamicQuestions1 = new List<SubDynamicQuestion>();
        }

        public int SubQuestionnaireQuestionOverwriteId { get; set; }
        public int SubQuestionnaireId { get; set; }
        public int QuestionnaireQuestionId { get; set; }
        public int QuestionOverwriteId { get; set; }
        public bool Dynamic { get; set; }
        public int QuestionSectionId { get; set; }
        public byte SectionNumber { get; set; }
        public short QuestionNumber { get; set; }
        public short ManagementCategoryId { get; set; }
        public short BenchmarkId { get; set; }
        public short QuestionDepartmentId { get; set; }
        public decimal MaxScore { get; set; }
        public byte MinAnswer { get; set; }
        public byte MaxAnswer { get; set; }
        public string Hint { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Benchmark Benchmark { get; set; }
        public virtual ManagementCategory ManagementCategory { get; set; }
        public virtual QuestionDepartment QuestionDepartment { get; set; }
        public virtual QuestionnaireQuestion QuestionnaireQuestion { get; set; }
        public virtual QuestionOverwrite QuestionOverwrite { get; set; }
        public virtual QuestionSection QuestionSection { get; set; }
        public virtual ICollection<SQQOPossibleAnswer> SQQOPossibleAnswers { get; set; }
        public virtual ICollection<SubDynamicQuestion> SubDynamicQuestions { get; set; }
        public virtual ICollection<SubDynamicQuestion> SubDynamicQuestions1 { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}