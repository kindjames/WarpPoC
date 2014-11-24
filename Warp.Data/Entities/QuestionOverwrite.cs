using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class QuestionOverwrite
    {
        public QuestionOverwrite()
        {
            SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int QuestionOverwiteId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}