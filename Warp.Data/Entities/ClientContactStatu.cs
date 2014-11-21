using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ClientContactStatu
    {
        public ClientContactStatu()
        {
            ClientContactTrackings = new List<ClientContactTracking>();
        }

        public short ClientContactStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<ClientContactTracking> ClientContactTrackings { get; set; }
    }
}