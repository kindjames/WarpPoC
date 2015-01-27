using Effort;
using Warp.Core.Infrastructure.General;
using Warp.Data.Migrations;
using Warp.Data.Migrations.DataSeed;

namespace Warp.Testing.Unit.Data.Util
{
    internal static class InMemoryDatabaseFactory
    {
        public static MigrationsAndTestingContext Build()
        {
            var connection = DbConnectionFactory.CreateTransient();

            var context = new MigrationsAndTestingContext(new DateTimeProvider(), connection, true);

            DataFactoryResolver.Seed(context);

            return context;
        }
    }
}