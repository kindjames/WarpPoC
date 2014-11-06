using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuConfigBranch
    {
        public int MenuConfigBranchID { get; set; }
        public int MenuConfigID { get; set; }
        public int BranchID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> Permission { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}
