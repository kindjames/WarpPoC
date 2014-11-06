using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandStatus1
    {
        public BrandStatus1()
        {
            this.Brand1 = new List<Brand1>();
            this.BrandHistory1 = new List<BrandHistory1>();
        }

        public short BrandStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Brand1> Brand1 { get; set; }
        public virtual ICollection<BrandHistory1> BrandHistory1 { get; set; }
    }
}
