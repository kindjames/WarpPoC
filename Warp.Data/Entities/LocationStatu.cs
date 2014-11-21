using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class LocationStatu
    {
        public LocationStatu()
        {
            Locations = new List<Location>();
        }

        public int LocationStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}