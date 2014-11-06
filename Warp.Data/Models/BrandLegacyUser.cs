using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandLegacyUser
    {
        public int BrandLegacyID { get; set; }
        public int BrandID { get; set; }
        public int LegacyID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
