using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class GeographicRegion
    {
        public GeographicRegion()
        {
            GeographicCounties = new List<GeographicCounty>();
        }

        public int GeographicRegionId { get; set; }
        public short GeographicCountryId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual GeographicCountry GeographicCountry { get; set; }
        public virtual ICollection<GeographicCounty> GeographicCounties { get; set; }
    }
}