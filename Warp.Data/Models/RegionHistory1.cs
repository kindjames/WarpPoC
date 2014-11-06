using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionHistory1
    {
        public int RegionHistoryID { get; set; }
        public int RegionID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short RegionStatusID { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public short EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public virtual Region1 Region1 { get; set; }
        public virtual RegionStatus1 RegionStatus1 { get; set; }
    }
}
