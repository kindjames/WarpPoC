using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicWorldArea
    {
        public GeographicWorldArea()
        {
            this.GeographicCountries = new List<GeographicCountry>();
        }

        public int GeographicWorldAreaID { get; set; }
        public string Name { get; set; }
        public string DefaultLocalisation { get; set; }
        public virtual ICollection<GeographicCountry> GeographicCountries { get; set; }
    }
}
