using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicCounty
    {
        public GeographicCounty()
        {
            this.GeographicLocations = new List<GeographicLocation>();
        }

        public int GeographicCountyID { get; set; }
        public int GeographicRegionID { get; set; }
        public string Name { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; }
        public virtual ICollection<GeographicLocation> GeographicLocations { get; set; }
    }
}
