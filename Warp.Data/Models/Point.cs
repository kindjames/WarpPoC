using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Point
    {
        public Point()
        {
            this.VisitPoints = new List<VisitPoint>();
        }

        public int PointID { get; set; }
        public int AssessorID { get; set; }
        public short PointReasonID { get; set; }
        public int Value { get; set; }
        public int EnteredByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual PointReason PointReason { get; set; }
        public virtual ICollection<VisitPoint> VisitPoints { get; set; }
    }
}
