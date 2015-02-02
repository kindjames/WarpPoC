using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hGem.Core.Data;
using hGem.Core.Infrastructure.Configuration;
using hGem.Core.Infrastructure.General;
using hGem.Core.Infrastructure.Util;

namespace hGem.Data.Context
{
    public abstract class ApplicationDbContextBase : DbContext, IApplicationDbContext
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        protected ApplicationDbContextBase(IDateTimeProvider dateTimeProvider, DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            _dateTimeProvider = dateTimeProvider;
        }

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

            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());

                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" + sb, ex); // Add the original exception as the innerException
            }
        }
    }
}