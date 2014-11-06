using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicRegion
    {
        public GeographicRegion()
        {
            this.GeographicCounties = new List<GeographicCounty>();
        }

        public int GeographicRegionID { get; set; }
        public short GeographicCountryID { get; set; }
        public string Name { get; set; }
        public virtual GeographicCountry GeographicCountry { get; set; }
        public virtual ICollection<GeographicCounty> GeographicCounties { get; set; }
    }
}
