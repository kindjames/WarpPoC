namespace Warp.Data.Entities
{
    public partial class BriefBranch
    {
        public int BriefBranchID { get; set; }
        public int BranchID { get; set; }
        public int BriefID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Brief Brief { get; set; }
    }
}
