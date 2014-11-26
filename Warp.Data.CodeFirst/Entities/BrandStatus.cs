using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class BrandStatus : EntityBase
    {
        public BrandStatus()
        {
            Brands = new List<Brand>();
        }

        public int BrandStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}