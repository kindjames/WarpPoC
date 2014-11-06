using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerRegion
    {
        public int ManagerRegionID { get; set; }
        public int ManagerID { get; set; }
        public int RegionID { get; set; }
        public virtual Region1 Region1 { get; set; }
    }
}
