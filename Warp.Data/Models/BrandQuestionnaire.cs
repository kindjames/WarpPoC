using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandQuestionnaire
    {
        public int BrandQuestionnaireID { get; set; }
        public int BrandID { get; set; }
        public int QuestionnaireID { get; set; }
        public bool Permission { get; set; }
        public int SubQuestionnaireID { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual SubQuestionnaire SubQuestionnaire { get; set; }
    }
}
