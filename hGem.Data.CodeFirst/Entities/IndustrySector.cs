using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class IndustrySector : EntityBase
    {
        public IndustrySector()
        {
            Brands = new Collection<Brand>();
        }

        [Required]
        public string SectorName { get; set; }

        [Required]
        public string SectorNameForAssessor { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}