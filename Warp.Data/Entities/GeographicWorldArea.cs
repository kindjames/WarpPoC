using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class GeographicWorldArea
    {
        public GeographicWorldArea()
        {
            this.GeographicCountries = new List<GeographicCountry>();
        }

        public int GeographicWorldAreaID { get; set; }
        public string Name { get; set; }
        public string DefaultLocalisation { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GeographicCountry> GeographicCountries { get; set; }
    }
}
