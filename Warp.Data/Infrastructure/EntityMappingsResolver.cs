using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Warp.Data.Infrastructure
{
    public class EntityMappingsResolver : IEntityMappingsResolver
    {
        private readonly Lazy<IEnumerable<object>> _entityTypes;

        public EntityMappingsResolver()
        {
            _entityTypes = new Lazy<IEnumerable<dynamic>>(() =>
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                    .Select(Activator.CreateInstance)
            );
        }

        public void AddAllConfigurations(DbModelBuilder modelBuilder)
        {
            var mappings = _entityTypes.Value;

            foreach (var mapping in mappings)
            {
                modelBuilder.Configurations.Add((dynamic) mapping);
            }
        }
    }
}