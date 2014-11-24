using System;

namespace Warp.Data.Entities
{
    public class VisitStatusHistory
    {
        public int VisitStatusHistoryId { get; set; }
        public int VisitId { get; set; }
        public short VisitStatusId { get; set; }
        public short AdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime DateValidTo { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
        public virtual VisitStatu VisitStatu1 { get; set; }
    }
}