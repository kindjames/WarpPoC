using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class BriefConfiguration
    {
        public BriefConfiguration()
        {
            this.BriefConfigurationBranches = new List<BriefConfigurationBranch>();
            this.BriefConfigurationBrands = new List<BriefConfigurationBrand>();
        }

        public int BriefConfigurationID { get; set; }
        public int BriefID { get; set; }
        public short BriefSectionID { get; set; }
        public int BriefItemID { get; set; }
        public string Text { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brief Brief { get; set; }
        public virtual BriefItem BriefItem { get; set; }
        public virtual BriefSection BriefSection { get; set; }
        public virtual ICollection<BriefConfigurationBranch> BriefConfigurationBranches { get; set; }
        public virtual ICollection<BriefConfigurationBrand> BriefConfigurationBrands { get; set; }
    }
}
