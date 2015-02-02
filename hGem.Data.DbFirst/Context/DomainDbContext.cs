using System.Data.Entity;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Context
{
    public sealed class DomainDbContext : ApplicationDbContextBase, IDomainDbContext
    {
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}