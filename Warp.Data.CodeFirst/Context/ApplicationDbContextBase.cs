using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Util;

namespace Warp.Data.Context
{
    public abstract class ApplicationDbContextBase : DbContext, IApplicationDbContext
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        protected ApplicationDbContextBase(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(NameOrConnectionString(applicationConfig))
        {
            _dateTimeProvider = dateTimeProvider;

            if (applicationConfig.IsEntityFrameworkLoggingEnabled)
            {
                Database.Log = s => Debug.Write(s);
            }

            var _ = typeof(SqlProviderServices);
        }

        static string NameOrConnectionString(IApplicationConfig applicationConfig)
        {
            CheckArgument.NotNull(applicationConfig, "applicationConfig");

            return "name=" + applicationConfig.DbContextName;
        }

        public override Task<int> SaveChangesAsync()
        {
            return Task.FromResult(SaveChanges());
        }

        public void CreateOrUpdateEntity<TEntity>(TEntity entity) where TEntity : EntityBase
        {
            var set = Set<TEntity>();

            if (set.Any(e => e.Id == entity.Id))
            {
                Entry(entity).State = EntityState.Modified;
            }
            else
            {
                set.Add(entity);
            }
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
                    entityBase.DateCreated = _dateTimeProvider.UtcNow();
                    entityBase.Active = true;
                }

                // Soft-deletes
                if (entity.State == EntityState.Deleted)
                {
                    entityBase.Active = false;
                    entity.State = EntityState.Modified;
                }

                entityBase.DateUpdated = _dateTimeProvider.UtcNow();
            }

            return base.SaveChanges();
        }
    }
}