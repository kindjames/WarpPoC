using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ContactAddressType
    {
        public ContactAddressType()
        {
            ContactAddressBranches = new List<ContactAddressBranch>();
            ContactAddressBrands = new List<ContactAddressBrand>();
            ContactAddressClients = new List<ContactAddressClient>();
            ContactAddressUserRoles = new List<ContactAddressUserRole>();
            ContactAddressCustomers = new List<ContactAddressCustomer>();
        }

        public int ContactAddressTypeId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
    }
}