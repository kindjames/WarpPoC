using System.Data.Entity;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Entities;

namespace Warp.Data.Context
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