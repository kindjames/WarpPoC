using System;

namespace Warp.Data.Entities
{
    public class RailStation
    {
        public short RailStationId { get; set; }
        public string Name { get; set; }
        public bool Underground { get; set; }
        public int GeographicPostCodeId { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}