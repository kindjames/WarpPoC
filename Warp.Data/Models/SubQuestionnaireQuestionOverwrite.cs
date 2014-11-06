using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SubQuestionnaireQuestionOverwrite
    {
        public SubQuestionnaireQuestionOverwrite()
        {
            this.SQQOPossibleAnswers = new List<SQQOPossibleAnswer>();
            this.SubDynamicQuestions = new List<SubDynamicQuestion>();
            this.SubDynamicQuestions1 = new List<SubDynamicQuestion>();
        }

        public int SubQuestionnaireQuestionOverwriteID { get; set; }
        public int SubQuestionnaireID { get; set; }
        public int QuestionnaireQuestionID { get; set; }
        public int QuestionOverwriteID { get; set; }
        public bool Dynamic { get; set; }
        public int QuestionSectionID { get; set; }
        public byte SectionNumber { get; set; }
        public short QuestionNumber { get; set; }
        public short ManagementCategoryID { get; set; }
        public short BenchmarkID { get; set; }
        public short QuestionDepartmentID { get; set; }
        public decimal MaxScore { get; set; }
        public byte MinAnswer { get; set; }
        public byte MaxAnswer { get; set; }
        public string Hint { get; set; }
        public System.DateTime LastUpdated { get; set; }
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
