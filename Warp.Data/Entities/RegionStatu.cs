using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class RegionStatu
    {
        public RegionStatu()
        {
            Regions = new List<Region>();
            RegionHistories = new List<RegionHistory>();
        }

        public int RegionStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<RegionHistory> RegionHistories { get; set; }
    }
}