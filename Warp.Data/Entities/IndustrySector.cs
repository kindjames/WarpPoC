using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class IndustrySector
    {
        public IndustrySector()
        {
            this.Brands = new List<Brand>();
        }

        public int IndustrySectorID { get; set; }
        public string SectorName { get; set; }
        public string SectorNameForAssessor { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual IndustrySector IndustrySector1 { get; set; }
        public virtual IndustrySector IndustrySector2 { get; set; }
    }
}
