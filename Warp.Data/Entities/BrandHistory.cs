using System;

namespace Warp.Data.Entities
{
    public partial class BrandHistory
    {
        public int BrandHistoryID { get; set; }
        public int BrandID { get; set; }
        public int BrandStatusID { get; set; }
        public int EnteredByUserRoleID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual BrandStatu BrandStatu { get; set; }
    }
}
