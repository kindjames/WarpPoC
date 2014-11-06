using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CustomerClient
    {
        public int CustomerClientID { get; set; }
        public int CustomerID { get; set; }
        public int ClientID { get; set; }
        public int CustomerLinkStatusID { get; set; }
        public bool PrimaryCustomer { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerLinkStatu CustomerLinkStatu { get; set; }
    }
}
