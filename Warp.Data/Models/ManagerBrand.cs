using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerBrand
    {
        public int ManagerBrand1 { get; set; }
        public int ManagerID { get; set; }
        public int BrandID { get; set; }
        public virtual Brand1 Brand1 { get; set; }
    }
}
