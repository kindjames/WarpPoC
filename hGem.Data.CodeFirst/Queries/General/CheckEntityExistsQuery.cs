using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Data;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.General
{
    public class CheckEntityExistsQuery<TEntity> : IQuery<bool>
        where TEntity : EntityBase
    {
        public Guid EntityId { get; set; }
    }

    public class CheckEntityExistsQueryValidator<TEntity> : AbstractValidator<CheckEntityExistsQuery<TEntity>> where TEntity : EntityBase
    {
        public CheckEntityExistsQueryValidator()
        {
            RuleFor(q => q.EntityId).NotEmptyGuid();
        }
    }

    public class CheckEntityExistsQueryHandler<TEntity> : IQueryHandler<CheckEntityExistsQuery<TEntity>, bool>
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public CheckEntityExistsQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(CheckEntityExistsQuery<TEntity> query)
        {
            return _dbContext.Set<TEntity>()
                .Any(e => e.Id == query.EntityId);
        }
    }
}