using System;

namespace Warp.Data.Entities
{
    public class BriefConfigurationBranch
    {
        public int BriefConfigurationBranchId { get; set; }
        public int BriefConfigurationId { get; set; }
        public int BranchId { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}