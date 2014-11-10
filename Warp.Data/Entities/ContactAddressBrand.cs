using System;

namespace Warp.Data.Entities
{
    public partial class ContactAddressBrand
    {
        public int ContactAddressBrandID { get; set; }
        public int ContactAddressID { get; set; }
        public int BrandID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
