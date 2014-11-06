using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonBrand
    {
        public int PersonBrandID { get; set; }
        public int PersonID { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
