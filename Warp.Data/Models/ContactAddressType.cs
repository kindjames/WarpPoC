using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressType
    {
        public ContactAddressType()
        {
            this.ContactAddressBranches = new List<ContactAddressBranch>();
            this.ContactAddressBrands = new List<ContactAddressBrand>();
            this.ContactAddressBranch1 = new List<ContactAddressBranch1>();
            this.ContactAddressBrand1 = new List<ContactAddressBrand1>();
            this.ContactAddressClients = new List<ContactAddressClient>();
            this.ContactAddressCustomers = new List<ContactAddressCustomer>();
            this.ContactAddressUserRoles = new List<ContactAddressUserRole>();
        }

        public int ContactAddressTypeID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressBranch1> ContactAddressBranch1 { get; set; }
        public virtual ICollection<ContactAddressBrand1> ContactAddressBrand1 { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
    }
}
