using System.Data.Entity;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public interface IAuthenticationDbContext : IApplicationDbContext
    {
        //IDbSet<RoleGroup> RoleGroups { get; set; }
        IDbSet<User> Users { get; set; }
    }
}