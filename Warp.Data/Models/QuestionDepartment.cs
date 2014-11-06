using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionDepartment
    {
        public QuestionDepartment()
        {
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public short QuestionDepartmentID { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
