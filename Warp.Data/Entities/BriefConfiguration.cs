using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class BriefConfiguration
    {
        public BriefConfiguration()
        {
            BriefConfigurationBranches = new List<BriefConfigurationBranch>();
            BriefConfigurationBrands = new List<BriefConfigurationBrand>();
        }

        public int BriefConfigurationId { get; set; }
        public int BriefId { get; set; }
        public short BriefSectionId { get; set; }
        public int BriefItemId { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brief Brief { get; set; }
        public virtual BriefItem BriefItem { get; set; }
        public virtual BriefSection BriefSection { get; set; }
        public virtual ICollection<BriefConfigurationBranch> BriefConfigurationBranches { get; set; }
        public virtual ICollection<BriefConfigurationBrand> BriefConfigurationBrands { get; set; }
    }
}