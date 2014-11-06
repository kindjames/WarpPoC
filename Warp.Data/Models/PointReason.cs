using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PointReason
    {
        public PointReason()
        {
            this.Points = new List<Point>();
        }

        public short PointReasonID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Point> Points { get; set; }
    }
}
