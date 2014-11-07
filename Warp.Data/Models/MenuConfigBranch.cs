using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuConfigBranch
    {
        public int MenuConfigBranchID { get; set; }
        public int MenuConfigID { get; set; }
        public int BranchID { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public Nullable<bool> Permission { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}
