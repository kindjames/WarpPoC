using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Customer
    {
        public Customer()
        {
            Users = new List<User>();
            ContactAddressCustomers = new List<ContactAddressCustomer>();
            CustomerClients = new List<CustomerClient>();
            CustomerUsers = new List<CustomerUser>();
            MaintenanceCustomers = new List<MaintenanceCustomer>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public string DisplayName { get; set; }
        public string CustomerCode { get; set; }
        public int DefaultLanguageId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<ContactAddressCustomer> ContactAddressCustomers { get; set; }
        public virtual ICollection<CustomerClient> CustomerClients { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<MaintenanceCustomer> MaintenanceCustomers { get; set; }
    }
}