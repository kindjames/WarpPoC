using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientQuestionnaire
    {
        public int ClientQuestionnaireID { get; set; }
        public int ClientID { get; set; }
        public int QuestionnaireID { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}
