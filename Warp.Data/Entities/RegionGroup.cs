using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class RegionGroup
    {
        public RegionGroup()
        {
            this.Regions = new List<Region>();
        }

        public int RegionGroupID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
