using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ContactAddressType
    {
        public ContactAddressType()
        {
            this.ContactAddressBranches = new List<ContactAddressBranch>();
            this.ContactAddressBrands = new List<ContactAddressBrand>();
            this.ContactAddressClients = new List<ContactAddressClient>();
            this.ContactAddressUserRoles = new List<ContactAddressUserRole>();
            this.ContactAddressCustomers = new List<ContactAddressCustomer>();
        }

        public int ContactAddressTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
    }
}
