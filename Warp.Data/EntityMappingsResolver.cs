using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Warp.Data
{
    public static class EntityMappingsResolver
    {
        public static void AddAllConfigurations(DbModelBuilder modelBuilder)
        {
            var mapTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof (EntityTypeConfiguration<>));

            foreach (var mapType in mapTypes)
            {
                dynamic mapInstance = Activator.CreateInstance(mapType);
                modelBuilder.Configurations.Add(mapInstance);
            }
        }
    }
}