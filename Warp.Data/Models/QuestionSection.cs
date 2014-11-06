using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionSection
    {
        public QuestionSection()
        {
            this.Questions = new List<Question>();
            this.QuestionnaireQuestions = new List<QuestionnaireQuestion>();
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int QuestionSectionID { get; set; }
        public string Title { get; set; }
        public Nullable<bool> Active { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
