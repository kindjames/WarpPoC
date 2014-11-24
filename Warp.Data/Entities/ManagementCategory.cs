using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ManagementCategory
    {
        public ManagementCategory()
        {
            Questions = new List<Question>();
            QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public short ManagementCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}