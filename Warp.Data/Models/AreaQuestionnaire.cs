using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaQuestionnaire
    {
        public int AreaQuestionnaireID { get; set; }
        public int AreaID { get; set; }
        public int QuestionnaireID { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireID { get; set; }
        public virtual Area Area { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}
