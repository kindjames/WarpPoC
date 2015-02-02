using System.Data.Entity;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Context
{
    public sealed class AuthenticationDbContext : ApplicationDbContextBase, IAuthenticationDbContext
    {
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}