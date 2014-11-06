using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandHistory1
    {
        public int BrandHistoryID { get; set; }
        public int BrandID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short BrandStatusID { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public virtual Brand1 Brand1 { get; set; }
        public virtual BrandStatus1 BrandStatus1 { get; set; }
    }
}
