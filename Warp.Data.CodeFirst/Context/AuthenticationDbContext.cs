using System.Data.Entity;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public sealed class AuthenticationDbContext : ApplicationDbContextBase, IAuthenticationDbContext
    {
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}