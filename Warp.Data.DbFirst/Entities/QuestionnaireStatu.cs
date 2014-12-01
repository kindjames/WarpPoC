using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class QuestionnaireStatus
    {
        public QuestionnaireStatus()
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