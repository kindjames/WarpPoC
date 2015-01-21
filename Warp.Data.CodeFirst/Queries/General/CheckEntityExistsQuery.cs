using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.General
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