using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaHistory1
    {
        public int AreaHistoryID { get; set; }
        public int AreaID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short AreaStatusID { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public virtual Area1 Area1 { get; set; }
        public virtual AreaStatus1 AreaStatus1 { get; set; }
    }
}
