namespace Warp.Data.Entities
{
    public partial class BriefConfigurationBranch
    {
        public int BriefConfigurationBranchID { get; set; }
        public int BriefConfigurationID { get; set; }
        public int BranchID { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}
