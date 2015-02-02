using System;
using System.Linq;
using FluentValidation.Validators;
using hGem.Core.Data;
using hGem.Data.Context;

namespace hGem.Data.Infrastructure.Validation
{
    public class EntityExistsValidator<TEntity> : PropertyValidator where TEntity : EntityBase
    {
        readonly IDomainDbContext _dbContext;

        public EntityExistsValidator(IDomainDbContext dbContext)
            : base("Property {PropertyName} contains more than 10 items!")
        {
            _dbContext = dbContext;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var entityId = (Guid) context.PropertyValue;

            return !_dbContext.Set<TEntity>()
                .Any(e => e.Id == entityId);
        }
    }
}