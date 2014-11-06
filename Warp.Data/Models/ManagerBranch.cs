using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerBranch
    {
        public int ManagerBranchID { get; set; }
        public int ManagerID { get; set; }
        public int BranchID { get; set; }
        public virtual Branch1 Branch1 { get; set; }
    }
}
