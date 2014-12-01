using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class IndustrySector : EntityBase
    {
        public IndustrySector()
        {
            Brands = new List<Brand>();
        }

        public int IndustrySectorId { get; set; }
        public string SectorName { get; set; }
        public string SectorNameForAssessor { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}