using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionLegacyUser
    {
        public int RegionLegacyID { get; set; }
        public int RegionID { get; set; }
        public int LegacyID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Region Region { get; set; }
    }
}
