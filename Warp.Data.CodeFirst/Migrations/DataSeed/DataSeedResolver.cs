using System.Data.Entity.Migrations;

namespace Warp.Data.Migrations.DataSeed
{
    internal static class DataSeedResolver
    {
        public static void Seed(InternalMigrationsInitializationContext context)
        {
            context.Users.AddOrUpdate(new UserDataFactory().Build());
            context.Roles.AddOrUpdate(new RoleDataFactory().Build());
        }
    }
}