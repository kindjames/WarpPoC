using System.Data.Entity;
using Warp.Data.Entities;
using Warp.Data.Mapping;

namespace Warp.Data.Context
{
    public interface IDomainDbContext : IApplicationDbContext
    {
        IDbSet<Client> Clients { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Brand> Brands { get; set; }
        IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }

    public sealed class DomainDbContext : ApplicationDbContextBase, IDomainDbContext
    {
        public DomainDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new ClientAccountManagerMap());
        }
    }
}