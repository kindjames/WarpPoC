using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressClient
    {
        public int ContactAddressClientID { get; set; }
        public int ContactAddressID { get; set; }
        public int ClientID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
