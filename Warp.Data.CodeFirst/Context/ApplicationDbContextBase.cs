using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public abstract class ApplicationDbContextBase : DbContext, IApplicationDbContext
    {
        protected ApplicationDbContextBase()
            : base("name=WarpPoCContext")
        {
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
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
    }
}