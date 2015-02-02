using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class GeographicPostCode
    {
        public GeographicPostCode()
        {
            Airports = new List<Airport>();
            AssessorGeographicPostCodes = new List<AssessorGeographicPostCode>();
            RailStations = new List<RailStation>();
        }

        public int GeographicPostCodeId { get; set; }
        public int GeographicPostalAreaId { get; set; }
        public string Name { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Airport> Airports { get; set; }
        public virtual ICollection<AssessorGeographicPostCode> AssessorGeographicPostCodes { get; set; }
        public virtual ICollection<RailStation> RailStations { get; set; }
        public virtual GeographicPostalArea GeographicPostalArea { get; set; }
    }
}