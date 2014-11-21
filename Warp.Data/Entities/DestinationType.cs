using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class DestinationType
    {
        public DestinationType()
        {
            Destinations = new List<Destination>();
        }

        public int DestinationTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}