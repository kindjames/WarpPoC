using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Airport
    {
        public short AirportID { get; set; }
        public string Name { get; set; }
        public string AirportCode { get; set; }
        public int GeographicPostCodeID { get; set; }
        public bool Active { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}
