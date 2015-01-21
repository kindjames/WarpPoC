using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.General
{
    public class GetEntityQuery<TEntity> : IQuery<TEntity>
        where TEntity : EntityBase
    {
        public Guid EntityId { get; set; }
    }

    public class GetEntityQueryValidator<TEntity> : AbstractValidator<GetEntityQuery<TEntity>>
        where TEntity : EntityBase
    {
        public GetEntityQueryValidator()
        {
            RuleFor(q => q.EntityId).NotEmptyGuid();
        }
    }

    public class GetEntityQueryHandler<TEntity> : IQueryHandler<GetEntityQuery<TEntity>, TEntity>
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public GetEntityQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Handle(GetEntityQuery<TEntity> query)
        {
            return _dbContext.Set<TEntity>()
                .SingleOrDefault(e => e.Id == query.EntityId);
        }
    }
}