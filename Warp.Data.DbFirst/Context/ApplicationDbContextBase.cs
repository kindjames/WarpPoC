using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Context
{
    public abstract class ApplicationDbContextBase : DbContext, IApplicationDbContext
    {
        static readonly Lazy<IEnumerable<dynamic>> EntityMappings = new Lazy<IEnumerable<dynamic>>(() =>
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.BaseType != null && t.BaseType.IsGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                    .Select(Activator.CreateInstance)
            );

        static ApplicationDbContextBase()
        {
            Database.SetInitializer<AuthenticationDbContext>(null);
        }

        protected ApplicationDbContextBase()
            : base("name=HospitalityGEMLocalContext")
        {
            var _ = typeof(SqlProviderServices);
        }

        public override Task<int> SaveChangesAsync()
        {
            return Task.FromResult(SaveChanges());
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));

            foreach (var entity in entities)
            {
                var entityBase = ((EntityBase)entity.Entity);

                // New entities
                if (entity.State == EntityState.Added)
                {
                    entityBase.DateCreated = DateTime.UtcNow;
                    entityBase.Active = true;
                }

                // Soft-deletes
                if (entity.State == EntityState.Deleted)
                {
                    entityBase.Active = false;
                    entity.State = EntityState.Modified;
                }

                entityBase.DateUpdated = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mappings = EntityMappings.Value;

            foreach (var mapping in mappings)
            {
                modelBuilder.Configurations.Add(mapping);
            }
        }
    }
}