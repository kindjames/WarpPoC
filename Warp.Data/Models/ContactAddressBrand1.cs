using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressBrand1
    {
        public int ContactAddressBrandID { get; set; }
        public int ContactAddressID { get; set; }
        public int BrandID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Brand1 Brand1 { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
