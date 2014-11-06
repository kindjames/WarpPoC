using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandStatu
    {
        public BrandStatu()
        {
            this.Brands = new List<Brand>();
            this.BrandHistories = new List<BrandHistory>();
        }

        public int BrandStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<BrandHistory> BrandHistories { get; set; }
    }
}
