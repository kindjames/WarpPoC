using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Migrations
{
    public class InternalMigrationsInitializationContext : ApplicationDbContextBase
    {
        public InternalMigrationsInitializationContext()
            : base(new ApplicationConfig(), new DateTimeProvider())
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<TextResource> TextResources { get; set; }
        public IDbSet<TextResourceIdentifier> TextResourceIdentifiers { get; set; }
        public IDbSet<Language> Languages { get; set; }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries();

            foreach (var entity in entities)
            {
                var entityBase = (EntityBase) entity.Entity;

                if (entityBase.Id == Guid.Empty)
                {
                    entityBase.Id = Guid.NewGuid();
                }
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