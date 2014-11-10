using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class GeographicLocation
    {
        public GeographicLocation()
        {
            this.ContactAddressGeoLocations = new List<ContactAddressGeoLocation>();
        }

        public int GeographicLocationID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
    }
}
