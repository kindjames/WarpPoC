using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddress
    {
        public ContactAddress()
        {
            this.ContactAddressBranches = new List<ContactAddressBranch>();
            this.ContactAddressBrands = new List<ContactAddressBrand>();
            this.ContactAddressGeoLocations = new List<ContactAddressGeoLocation>();
            this.ContactAddressUserRoles = new List<ContactAddressUserRole>();
            this.ContactAddressBranch1 = new List<ContactAddressBranch1>();
            this.ContactAddressBrand1 = new List<ContactAddressBrand1>();
            this.ContactAddressClients = new List<ContactAddressClient>();
            this.ContactAddressCustomers = new List<ContactAddressCustomer>();
        }

        public int ContactAddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public Nullable<int> GeographicPostcodeID { get; set; }
        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual ICollection<ContactAddressBranch1> ContactAddressBranch1 { get; set; }
        public virtual ICollection<ContactAddressBrand1> ContactAddressBrand1 { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
    }
}
