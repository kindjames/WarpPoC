using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitPoint
    {
        public int VisitPointId { get; set; }
        public int VisitId { get; set; }
        public int PointId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Point Point { get; set; }
        public virtual Visit Visit { get; set; }
    }
}