using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class PointReason
    {
        public PointReason()
        {
            Points = new List<Point>();
        }

        public short PointReasonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Point> Points { get; set; }
    }
}