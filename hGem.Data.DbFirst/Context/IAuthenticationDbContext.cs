using System.Data.Entity;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Context
{
    public interface IAuthenticationDbContext : IApplicationDbContext
    {
        IDbSet<Role> Roles { get; set; }
        IDbSet<User> Users { get; set; }
    }
}