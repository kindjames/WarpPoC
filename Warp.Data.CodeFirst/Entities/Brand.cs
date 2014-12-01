using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Brand : EntityBase
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int BrandStatusId { get; set; }
        public int IndustrySectorId { get; set; }
        public bool Visible { get; set; }
        public virtual BrandStatus BrandStatus { get; set; }
        public virtual Client Client { get; set; }
        public virtual IndustrySector IndustrySector { get; set; }
    }
}