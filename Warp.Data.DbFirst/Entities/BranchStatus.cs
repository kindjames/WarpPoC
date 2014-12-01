using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class BranchStatus : EntityBase
    {
        public BranchStatus()
        {
            this.Branches = new List<Branch>();
            this.BranchHistories = new List<BranchHistory>();
        }

        public int BranchStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<BranchHistory> BranchHistories { get; set; }
    }
}
