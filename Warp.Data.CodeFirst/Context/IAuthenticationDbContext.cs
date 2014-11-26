using System.Data.Entity;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public interface IAuthenticationDbContext : IApplicationDbContext
    {
        IDbSet<Role> Roles { get; set; }
        IDbSet<User> Users { get; set; }
    }
}