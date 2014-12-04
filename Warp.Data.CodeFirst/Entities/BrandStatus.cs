using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class BrandStatus : EntityBase
    {
        public BrandStatus()
        {
            Brands = new Collection<Brand>();
        }

        public int BrandStatusId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}