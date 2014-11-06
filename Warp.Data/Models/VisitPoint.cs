using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitPoint
    {
        public int VisitPointID { get; set; }
        public int VisitID { get; set; }
        public int PointID { get; set; }
        public virtual Point Point { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
