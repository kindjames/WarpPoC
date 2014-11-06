using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuConfigBrand
    {
        public int MenuConfigBrandID { get; set; }
        public int MenuConfigID { get; set; }
        public int BrandID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public short AddedByAdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}
