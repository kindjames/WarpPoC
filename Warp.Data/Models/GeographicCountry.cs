using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicCountry
    {
        public GeographicCountry()
        {
            this.GeographicRegions = new List<GeographicRegion>();
        }

        public short GeographicCountryID { get; set; }
        public int GeographicWorldAreaID { get; set; }
        public string Name { get; set; }
        public int CurrencyID { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual GeographicWorldArea GeographicWorldArea { get; set; }
        public virtual ICollection<GeographicRegion> GeographicRegions { get; set; }
    }
}
