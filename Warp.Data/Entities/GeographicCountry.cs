using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class GeographicCountry :EntityBase
    {
        public GeographicCountry()
        {
            GeographicRegions = new List<GeographicRegion>();
        }

        public short GeographicCountryId { get; set; }
        public int GeographicWorldAreaId { get; set; }
        public string Name { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual GeographicWorldArea GeographicWorldArea { get; set; }
        public virtual ICollection<GeographicRegion> GeographicRegions { get; set; }
    }
}