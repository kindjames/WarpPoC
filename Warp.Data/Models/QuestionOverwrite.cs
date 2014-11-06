using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionOverwrite
    {
        public QuestionOverwrite()
        {
            this.SubQuestionnaireQuestionOverwrites = new List<SubQuestionnaireQuestionOverwrite>();
        }

        public int QuestionOverwiteID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
