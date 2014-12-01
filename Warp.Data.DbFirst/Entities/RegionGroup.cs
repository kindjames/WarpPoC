using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class RegionGroup
    {
        public RegionGroup()
        {
            Regions = new List<Region>();
        }

        public int RegionGroupId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}