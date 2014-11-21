using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class GeographicPostalArea
    {
        public GeographicPostalArea()
        {
            GeographicPostCodes = new List<GeographicPostCode>();
        }

        public int GeographicPostalAreaId { get; set; }
        public int GeographicLocationId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GeographicPostCode> GeographicPostCodes { get; set; }
    }
}