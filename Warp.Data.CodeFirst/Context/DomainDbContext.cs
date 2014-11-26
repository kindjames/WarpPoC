using System.Data.Entity;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public sealed class DomainDbContext : ApplicationDbContextBase, IDomainDbContext
    {
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        //public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}