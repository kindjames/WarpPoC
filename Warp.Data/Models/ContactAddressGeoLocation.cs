using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressGeoLocation
    {
        public int ContactAddressGeoLocationID { get; set; }
        public int ContactAddressID { get; set; }
        public Nullable<int> GeographicLocationID { get; set; }
        public decimal GeocodeX { get; set; }
        public decimal GeocodeY { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual GeographicLocation GeographicLocation { get; set; }
    }
}
