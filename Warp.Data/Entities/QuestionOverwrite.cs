using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SubQuestionnaireQuestionOverwrite> SubQuestionnaireQuestionOverwrites { get; set; }
    }
}
