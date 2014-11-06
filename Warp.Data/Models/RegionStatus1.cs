using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionStatus1
    {
        public RegionStatus1()
        {
            this.Region1 = new List<Region1>();
            this.RegionHistory1 = new List<RegionHistory1>();
        }

        public short RegionStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Region1> Region1 { get; set; }
        public virtual ICollection<RegionHistory1> RegionHistory1 { get; set; }
    }
}
