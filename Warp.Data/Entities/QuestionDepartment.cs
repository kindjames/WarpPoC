using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class QuestionDepartment
    {
        public QuestionDepartment()
        {
            QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public short QuestionDepartmentId { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}