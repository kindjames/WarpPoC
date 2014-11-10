using System;

namespace Warp.Data.Entities
{
    public partial class AreaHistory
    {
        public int AreaHistoryID { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public int AreaStatusID { get; set; }
        public int RegionID { get; set; }
        public string Code { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public int EnteredByUserRoleID { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Area Area { get; set; }
        public virtual Region Region { get; set; }
        public virtual AreaStatu AreaStatu { get; set; }
    }
}
