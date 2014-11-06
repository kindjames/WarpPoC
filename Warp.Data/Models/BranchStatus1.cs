using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchStatus1
    {
        public BranchStatus1()
        {
            this.Branch1 = new List<Branch1>();
            this.BranchHistory1 = new List<BranchHistory1>();
        }

        public short BranchStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Branch1> Branch1 { get; set; }
        public virtual ICollection<BranchHistory1> BranchHistory1 { get; set; }
    }
}
