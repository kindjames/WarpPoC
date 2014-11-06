using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaHistory
    {
        public int AreaHistoryID { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public int AreaStatusID { get; set; }
        public int RegionID { get; set; }
        public string Code { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public int EnteredByAdminID { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Area Area { get; set; }
        public virtual Region Region { get; set; }
        public virtual AreaStatu AreaStatu { get; set; }
    }
}
