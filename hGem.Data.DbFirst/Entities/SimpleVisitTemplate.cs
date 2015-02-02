using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class SimpleVisitTemplate
    {
        public SimpleVisitTemplate()
        {
            SimpleVisits = new List<SimpleVisit>();
        }

        public int SimpleVisitTemplateId { get; set; }
        public DateTime DateCreated { get; set; }
        public int AddedByAdminId { get; set; }
        public int QuestionnaireId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int? RequiredCount { get; set; }
        public DateTime? DateCountReached { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
    }
}