using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefItem
    {
        public BriefItem()
        {
            this.BriefConfigurations = new List<BriefConfiguration>();
        }

        public int BriefItemID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}
