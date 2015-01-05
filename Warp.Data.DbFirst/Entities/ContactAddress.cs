using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ContactAddress : EntityBase
    {
        public ContactAddress()
        {
            ContactAddressBranches = new List<ContactAddressBranch>();
            ContactAddressBrands = new List<ContactAddressBrand>();
            ContactAddressClients = new List<ContactAddressClient>();
            ContactAddressUserRoles = new List<ContactAddressUserRole>();
            ContactAddressCustomers = new List<ContactAddressCustomer>();
            ContactAddressGeoLocations = new List<ContactAddressGeoLocation>();
        }

        public int ContactAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public int? GeographicPostcodeId { get; set; }

        public virtual ICollection<ContactAddressBranch> ContactAddressBranches { get; set; }
        public virtual ICollection<ContactAddressBrand> ContactAddressBrands { get; set; }
        public virtual ICollection<ContactAddressClient> ContactAddressClients { get; set; }
        public virtual ICollection<ContactAddressUserRole> ContactAddressUserRoles { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public virtual ICollection<ContactAddressGeoLocation> ContactAddressGeoLocations { get; set; }
    }
}
