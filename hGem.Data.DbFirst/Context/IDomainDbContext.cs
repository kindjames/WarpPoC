using System.Data.Entity;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Context
{
    public interface IDomainDbContext : IApplicationDbContext
    {
        IDbSet<Client> Clients { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Brand> Brands { get; set; }
        IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}