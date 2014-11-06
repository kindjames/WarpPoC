using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchHistory1
    {
        public int BranchHistoryID { get; set; }
        public int BranchID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short BranchStatusID { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public virtual Branch1 Branch1 { get; set; }
        public virtual BranchStatus1 BranchStatus1 { get; set; }
    }
}
