using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonBranch
    {
        public int PersonBranchID { get; set; }
        public int PersonID { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
