using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class VisitType
    {
        public VisitType()
        {
            this.Questionnaires = new List<Questionnaire>();
            this.SimpleVisits = new List<SimpleVisit>();
            this.Visits = new List<Visit>();
            this.VisitTypeExpenseTypes = new List<VisitTypeExpenseType>();
        }

        public short VisitTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
    }
}
