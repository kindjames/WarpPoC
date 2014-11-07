using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionQuestionnaire
    {
        public int RegionQuestionnaireID { get; set; }
        public int RegionID { get; set; }
        public int QuestionnaireID { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Region Region { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}
