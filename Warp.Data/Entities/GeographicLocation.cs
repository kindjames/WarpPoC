using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class GeographicLocation
    {
        public GeographicLocation()
        {
            ContactAddressGeoLocations = new List<ContactAddressGeoLocation>();
        }

        public int GeographicLocationId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
    }
}