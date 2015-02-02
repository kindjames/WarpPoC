using System.Data.Common;
using System.Data.Entity;
using hGem.Core.Infrastructure.Configuration;
using hGem.Core.Infrastructure.General;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public class DomainDbContext : ApplicationDbContextBase, IDomainDbContext
    {
        public DomainDbContext(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(applicationConfig, dateTimeProvider)
        {
        }

        internal DomainDbContext(IDateTimeProvider dateTimeProvider, DbConnection existingConnection, bool contextOwnsConnection)
            : base(dateTimeProvider, existingConnection, contextOwnsConnection)
        {
        }

        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        //public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}