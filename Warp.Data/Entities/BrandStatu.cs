using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class BrandStatus
    {
        public BrandStatus()
        {
            Brands = new List<Brand>();
            BrandHistories = new List<BrandHistory>();
        }

        public int BrandStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<BrandHistory> BrandHistories { get; set; }
    }
}