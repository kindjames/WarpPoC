using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class RailStation
    {
        public short RailStationID { get; set; }
        public string Name { get; set; }
        public bool Underground { get; set; }
        public int GeographicPostCodeID { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}
