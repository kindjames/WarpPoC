using System.Data.Entity;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Migrations
{
    internal class InitializationContext : ApplicationDbContextBase
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}