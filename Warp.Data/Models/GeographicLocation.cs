using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicLocation
    {
        public GeographicLocation()
        {
            this.GeographicPostalAreas = new List<GeographicPostalArea>();
        }

        public int GeographicLocationID { get; set; }
        public int GeographicCounty { get; set; }
        public string Name { get; set; }
        public virtual GeographicCounty GeographicCounty1 { get; set; }
        public virtual ICollection<GeographicPostalArea> GeographicPostalAreas { get; set; }
    }
}
