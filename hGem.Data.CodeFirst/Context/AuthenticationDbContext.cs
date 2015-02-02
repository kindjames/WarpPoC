using System.Data.Entity;
using hGem.Core.Infrastructure.Configuration;
using hGem.Core.Infrastructure.General;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public sealed class AuthenticationDbContext : ApplicationDbContextBase, IAuthenticationDbContext
    {
        public AuthenticationDbContext(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(applicationConfig, dateTimeProvider)
        {
        }

        //public IDbSet<RoleGroup> RoleGroups { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}