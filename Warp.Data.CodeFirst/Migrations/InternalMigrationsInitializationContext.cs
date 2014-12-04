using System.Data.Entity;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Migrations
{
    public class InternalMigrationsInitializationContext : ApplicationDbContextBase
    {
        public InternalMigrationsInitializationContext()
            : base(new ApplicationConfig(), new DateTimeProvider())
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
    }
}