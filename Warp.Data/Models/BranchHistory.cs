using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchHistory
    {
        public int BranchHistoryID { get; set; }
        public int BranchID { get; set; }
        public int BranchStatusID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public int AreaID { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int EnteredByUserRoleID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BranchStatu BranchStatu { get; set; }
    }
}
