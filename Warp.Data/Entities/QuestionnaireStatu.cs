using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class QuestionnaireStatu
    {
        public QuestionnaireStatu()
        {
            Questionnaires = new List<Questionnaire>();
        }

        public short QuestionnaireStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}