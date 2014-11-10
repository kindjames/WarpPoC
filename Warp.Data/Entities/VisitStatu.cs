using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class VisitStatu
    {
        public VisitStatu()
        {
            this.SimpleVisits = new List<SimpleVisit>();
            this.Visits = new List<Visit>();
            this.VisitStatusHistories = new List<VisitStatusHistory>();
            this.VisitStatusHistories1 = new List<VisitStatusHistory>();
        }

        public short VisitStatusID { get; set; }
        public string AdminName { get; set; }
        public string ClientName { get; set; }
        public string AssessorName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<VisitStatusHistory> VisitStatusHistories { get; set; }
        public virtual ICollection<VisitStatusHistory> VisitStatusHistories1 { get; set; }
    }
}
