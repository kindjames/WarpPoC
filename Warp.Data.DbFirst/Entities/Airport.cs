using System;

namespace Warp.Data.DbFirst.Entities
{
    public class Airport
    {
        public short AirportId { get; set; }
        public string Name { get; set; }
        public string AirportCode { get; set; }
        public int GeographicPostCodeId { get; set; }
        public bool Active { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}