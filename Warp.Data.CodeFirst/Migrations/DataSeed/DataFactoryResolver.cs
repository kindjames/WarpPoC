using System;
using System.Linq;

namespace Warp.Data.Migrations.DataSeed
{
    public static class DataFactoryResolver
    {
        public static void Seed(MigrationsAndTestingContext context)
        {
            var dataFactoryType = typeof (IDataFactory);

            // Finds all implementations of IDataFactory.
            var dataFactories = dataFactoryType.Assembly
                .GetTypes()
                .Where(dataFactoryType.IsAssignableFrom)
                .Where(t => !t.IsInterface)
                .Select(Activator.CreateInstance)
                .OfType<IDataFactory>()
                .OrderBy(d => d.Order);

            foreach (var dataFactory in dataFactories)
            {
                dataFactory.AddDataToContext(context);
            }

            context.SaveChanges();
        }
    }
}