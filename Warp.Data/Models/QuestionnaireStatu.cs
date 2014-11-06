using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class QuestionnaireStatu
    {
        public QuestionnaireStatu()
        {
            this.Questionnaires = new List<Questionnaire>();
        }

        public short QuestionnaireStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}
