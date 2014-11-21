using System;

namespace Warp.Data.Entities
{
    public class ContactAddressCustomer
    {
        public int ContactAddressCustomer1 { get; set; }
        public int ContactAddressId { get; set; }
        public int CustomerId { get; set; }
        public int ContactAddressTypeId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}