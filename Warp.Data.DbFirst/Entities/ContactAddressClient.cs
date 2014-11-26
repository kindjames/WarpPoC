using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ContactAddressClient : EntityBase
    {
        public int ContactAddressClientId { get; set; }
        public int ContactAddressId { get; set; }
        public int ClientId { get; set; }
        public int ContactAddressTypeId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public virtual Client Client { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
