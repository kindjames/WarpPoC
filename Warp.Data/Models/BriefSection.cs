using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefSection
    {
        public BriefSection()
        {
            this.BriefConfigurations = new List<BriefConfiguration>();
        }

        public short BriefSectionID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BriefConfiguration> BriefConfigurations { get; set; }
    }
}
