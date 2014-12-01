using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitStatus
    {
        public VisitStatus()
        {
            SimpleVisits = new List<SimpleVisit>();
            Visits = new List<Visit>();
            VisitStatusHistories = new List<VisitStatusHistory>();
            VisitStatusHistories1 = new List<VisitStatusHistory>();
        }

        public short VisitStatusId { get; set; }
        public string AdminName { get; set; }
        public string ClientName { get; set; }
        public string AssessorName { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual ICollection<VisitStatusHistory> VisitStatusHistories { get; set; }
        public virtual ICollection<VisitStatusHistory> VisitStatusHistories1 { get; set; }
    }
}