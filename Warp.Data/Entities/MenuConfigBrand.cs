using System;

namespace Warp.Data.Entities
{
    public partial class MenuConfigBrand
    {
        public int MenuConfigBrandID { get; set; }
        public int MenuConfigID { get; set; }
        public int BrandID { get; set; }
        public short AddedByAdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool Permission { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}
