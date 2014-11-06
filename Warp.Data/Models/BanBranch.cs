using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BanBranch
    {
        public int BanBranchID { get; set; }
        public int BranchID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
