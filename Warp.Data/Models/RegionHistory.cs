using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RegionHistory
    {
        public int RegionHistoryID { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int RegionStatusID { get; set; }
        public string Code { get; set; }
        public int RegionGroupID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Region Region { get; set; }
        public virtual RegionStatu RegionStatu { get; set; }
    }
}
