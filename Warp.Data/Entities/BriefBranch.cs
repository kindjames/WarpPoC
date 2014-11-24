using System;

namespace Warp.Data.Entities
{
    public class BriefBranch
    {
        public int BriefBranchId { get; set; }
        public int BranchId { get; set; }
        public int BriefId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Brief Brief { get; set; }
    }
}