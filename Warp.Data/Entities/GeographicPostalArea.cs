using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GeographicPostCode> GeographicPostCodes { get; set; }
    }
}
