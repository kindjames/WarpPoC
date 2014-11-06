using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class GeographicPostalArea
    {
        public GeographicPostalArea()
        {
            this.GeographicPostCodes = new List<GeographicPostCode>();
        }

        public int GeographicPostalAreaID { get; set; }
        public int GeographicLocationID { get; set; }
        public string Name { get; set; }
        public virtual GeographicLocation GeographicLocation { get; set; }
        public virtual ICollection<GeographicPostCode> GeographicPostCodes { get; set; }
    }
}
