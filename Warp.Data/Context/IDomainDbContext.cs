using System.Data.Entity;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public interface IDomainDbContext : IApplicationDbContext
    {
        IDbSet<Client> Clients { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Brand> Brands { get; set; }
        IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}