using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Clients = new List<Client>();
            this.ContactAddressCustomers = new List<ContactAddressCustomer>();
            this.CustomerClients = new List<CustomerClient>();
            this.CustomerUsers = new List<CustomerUser>();
            this.MaintenanceCustomers = new List<MaintenanceCustomer>();
            this.UserRoles = new List<UserRole>();
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public string DisplayName { get; set; }
        public string CustomerCode { get; set; }
        public int DefaultLanguageID { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public virtual ICollection<CustomerClient> CustomerClients { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<MaintenanceCustomer> MaintenanceCustomers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
