using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BriefBrand
    {
        public int BriefBrand1 { get; set; }
        public int BrandID { get; set; }
        public int BriefID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Brief Brief { get; set; }
    }
}
