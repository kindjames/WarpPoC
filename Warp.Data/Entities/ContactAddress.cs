using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ContactAddress
    {
        public ContactAddress()
        {
            this.ContactAddressBranches = new List<ContactAddressBranch>();
            this.ContactAddressBrands = new List<ContactAddressBrand>();
            this.ContactAddressClients = new List<ContactAddressClient>();
            this.ContactAddressUserRoles = new List<ContactAddressUserRole>();
            this.ContactAddressCustomers = new List<ContactAddressCustomer>();
            this.ContactAddressGeoLocations = new List<ContactAddressGeoLocation>();
        }

        public int ContactAddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public Nullable<int> GeographicPostcodeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public virtual ICollection<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
    }
}
