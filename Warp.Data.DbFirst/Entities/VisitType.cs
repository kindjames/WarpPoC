using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitType
    {
        public VisitType()
        {
            Questionnaires = new List<Questionnaire>();
            SimpleVisits = new List<SimpleVisit>();
            Visits = new List<Visit>();
            VisitTypeExpenseTypes = new List<VisitTypeExpenseType>();
        }

        public short VisitTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
    }
}