using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ContactAddressGeoLocation
    {
        public int ContactAddressGeoLocationId { get; set; }
        public int ContactAddressId { get; set; }
        public int? GeographicLocationId { get; set; }
        public decimal GeocodeX { get; set; }
        public decimal GeocodeY { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual GeographicLocation GeographicLocation { get; set; }
    }
}