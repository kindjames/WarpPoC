using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class LocationStatu
    {
        public LocationStatu()
        {
            this.Locations = new List<Location>();
        }

        public int LocationStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
