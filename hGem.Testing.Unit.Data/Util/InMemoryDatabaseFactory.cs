using Effort;
using hGem.Core.Infrastructure.General;
using hGem.Data.Migrations;
using hGem.Data.Migrations.DataSeed;

namespace hGem.Testing.Unit.Data.Util
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