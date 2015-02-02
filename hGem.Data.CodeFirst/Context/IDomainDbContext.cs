using System.Data.Entity;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public interface IDomainDbContext : IApplicationDbContext
    {
        IDbSet<Client> Clients { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Brand> Brands { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<Role> Roles { get; set; }
        //IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}