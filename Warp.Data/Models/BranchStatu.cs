using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchStatu
    {
        public BranchStatu()
        {
            this.Branches = new List<Branch>();
            this.BranchHistories = new List<BranchHistory>();
        }

        public int BranchStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<BranchHistory> BranchHistories { get; set; }
    }
}
