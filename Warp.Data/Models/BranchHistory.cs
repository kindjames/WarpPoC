using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchHistory
    {
        public int BranchHistoryID { get; set; }
        public int BranchID { get; set; }
        public int BranchStatusID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public int AreaID { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int EnteredByAdminID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BranchStatu BranchStatu { get; set; }
    }
}
