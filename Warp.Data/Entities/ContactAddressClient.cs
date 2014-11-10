using System;

namespace Warp.Data.Entities
{
    public partial class ContactAddressClient : EntityBase
    {
        public int ContactAddressClientID { get; set; }
        public int ContactAddressID { get; set; }
        public int ClientID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public virtual Client Client { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
