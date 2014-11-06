using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Region1
    {
        public Region1()
        {
            this.ManagerRegions = new List<ManagerRegion>();
            this.RegionHistory1 = new List<RegionHistory1>();
        }

        public int RegionID { get; set; }
        public string Name { get; set; }
        public int AreaID { get; set; }
        public short RegionStatusID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public virtual Area1 Area1 { get; set; }
        public virtual ICollection<ManagerRegion> ManagerRegions { get; set; }
        public virtual RegionStatus1 RegionStatus1 { get; set; }
        public virtual ICollection<RegionHistory1> RegionHistory1 { get; set; }
    }
}
