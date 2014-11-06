using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonRegion
    {
        public int PersonRegionID { get; set; }
        public int PersonID { get; set; }
        public int RegionID { get; set; }
        public virtual Region Region { get; set; }
    }
}
