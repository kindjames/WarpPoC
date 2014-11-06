using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefConfigurationBrand
    {
        public int BriefConfigurationBrand1 { get; set; }
        public int BriefConfigurationID { get; set; }
        public int BrandID { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}
