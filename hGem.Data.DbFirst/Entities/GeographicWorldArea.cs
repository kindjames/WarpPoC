using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class GeographicWorldArea
    {
        public GeographicWorldArea()
        {
            GeographicCountries = new List<GeographicCountry>();
        }

        public int GeographicWorldAreaId { get; set; }
        public string Name { get; set; }
        public string DefaultLocalisation { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GeographicCountry> GeographicCountries { get; set; }
    }
}