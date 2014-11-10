using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Weather
    {
        public Weather()
        {
            this.VisitDetails = new List<VisitDetail>();
        }

        public short WeatherID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VisitDetail> VisitDetails { get; set; }
    }
}
