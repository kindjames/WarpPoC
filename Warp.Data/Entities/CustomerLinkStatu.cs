using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class CustomerLinkStatu
    {
        public CustomerLinkStatu()
        {
            CustomerClients = new List<CustomerClient>();
        }

        public int CustomerLinkStatusId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CustomerClient> CustomerClients { get; set; }
    }
}