using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class IndustrySector
    {
        public IndustrySector()
        {
            Brands = new List<Brand>();
        }

        public int IndustrySectorId { get; set; }
        public string SectorName { get; set; }
        public string SectorNameForAssessor { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual IndustrySector IndustrySector1 { get; set; }
        public virtual IndustrySector IndustrySector2 { get; set; }
    }
}