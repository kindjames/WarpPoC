using Warp.Data.Migrations.DataSeed;

namespace Warp.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Warp.Data.Migrations.MigrationsAndTestingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Warp.Data.Migrations.MigrationsAndTestingContext context)
        {
            DataFactoryResolver.Seed(context);
        }
    }
}
