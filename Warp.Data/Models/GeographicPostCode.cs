using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicPostCode
    {
        public GeographicPostCode()
        {
            this.Airports = new List<Airport>();
            this.AssessorGeographicPostCodes = new List<AssessorGeographicPostCode>();
            this.RailStations = new List<RailStation>();
        }

        public int GeographicPostCodeID { get; set; }
        public int GeographicPostalAreaID { get; set; }
        public string Name { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public virtual ICollection<Airport> Airports { get; set; }
        public virtual ICollection<AssessorGeographicPostCode> AssessorGeographicPostCodes { get; set; }
        public virtual GeographicPostalArea GeographicPostalArea { get; set; }
        public virtual ICollection<RailStation> RailStations { get; set; }
    }
}
