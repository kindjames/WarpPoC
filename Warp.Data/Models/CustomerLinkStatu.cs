using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CustomerLinkStatu
    {
        public CustomerLinkStatu()
        {
            this.CustomerClients = new List<CustomerClient>();
        }

        public int CustomerLinkStatusID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CustomerClient> CustomerClients { get; set; }
    }
}
