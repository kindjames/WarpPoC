using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientContactStatu
    {
        public ClientContactStatu()
        {
            this.ClientContactTrackings = new List<ClientContactTracking>();
        }

        public short ClientContactStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<ClientContactTracking> ClientContactTrackings { get; set; }
    }
}
