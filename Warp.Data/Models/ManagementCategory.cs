using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagementCategory
    {
        public ManagementCategory()
        {
            this.Questions = new List<Question>();
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public short ManagementCategoryID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
