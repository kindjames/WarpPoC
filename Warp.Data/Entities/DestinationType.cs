using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class DestinationType
    {
        public DestinationType()
        {
            this.Destinations = new List<Destination>();
        }

        public int DestinationTypeId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
