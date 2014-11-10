using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class RegionStatu
    {
        public RegionStatu()
        {
            this.Regions = new List<Region>();
            this.RegionHistories = new List<RegionHistory>();
        }

        public int RegionStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<RegionHistory> RegionHistories { get; set; }
    }
}
