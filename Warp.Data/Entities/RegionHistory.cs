using System;

namespace Warp.Data.Entities
{
    public partial class RegionHistory
    {
        public int RegionHistoryID { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int RegionStatusID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public int EnteredByUserRoleID { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public virtual Region Region { get; set; }
        public virtual RegionStatu RegionStatu { get; set; }
    }
}
