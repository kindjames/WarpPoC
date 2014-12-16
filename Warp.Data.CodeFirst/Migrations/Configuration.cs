using System.Data.Entity.Migrations;
using Warp.Data.Migrations.DataSeed;

namespace Warp.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<InternalMigrationsInitializationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InternalMigrationsInitializationContext context)
        {
            DataFactoryResolver.Seed(context);
        }
    }
}
