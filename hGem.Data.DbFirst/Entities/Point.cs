using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Point
    {
        public Point()
        {
            VisitPoints = new List<VisitPoint>();
        }

        public int PointId { get; set; }
        public int AssessorId { get; set; }
        public short PointReasonId { get; set; }
        public int Value { get; set; }
        public int EnteredByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual PointReason PointReason { get; set; }
        public virtual ICollection<VisitPoint> VisitPoints { get; set; }
    }
}