using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ContactAddressBrand
    {
        public int ContactAddressBrandId { get; set; }
        public int ContactAddressId { get; set; }
        public int BrandId { get; set; }
        public int ContactAddressTypeId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}