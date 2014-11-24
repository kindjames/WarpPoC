using System.Data.Entity;
using Warp.Data.Entities;
using Warp.Data.Mapping;

namespace Warp.Data.Context
{
    public sealed class AuthenticationDbContext : ApplicationDbContextBase, IAuthenticationDbContext
    {
        public AuthenticationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IDbSet<Role> Roles { get; set; }
        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}