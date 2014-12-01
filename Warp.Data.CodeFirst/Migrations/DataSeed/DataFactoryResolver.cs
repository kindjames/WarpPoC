using System;
using System.Linq;

namespace Warp.Data.Migrations.DataSeed
{
    internal static class DataFactoryResolver
    {
        public static void Seed(InternalMigrationsInitializationContext context)
        {
            var dataFactoryType = typeof (IDataFactory);

            // Finds all implementations of IDataFactory.
            var dataFactories = dataFactoryType.Assembly
                .GetTypes()
                .Where(dataFactoryType.IsAssignableFrom)
                .Where(t => !t.IsInterface);

            foreach (var dataFactory in dataFactories)
            {
                // Create and run factory.
                var factory = (IDataFactory) Activator.CreateInstance(dataFactory);

                factory.AddDataToContext(context);
            }

            context.SaveChanges();
        }
    }
}