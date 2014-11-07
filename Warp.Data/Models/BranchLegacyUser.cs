using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchLegacyUser
    {
        public int BranchLegacyID { get; set; }
        public int BranchID { get; set; }
        public int LegacyID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
