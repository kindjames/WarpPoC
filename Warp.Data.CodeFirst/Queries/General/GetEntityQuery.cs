using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.General
{
    public class GetEntityQuery<TEntity> : IQuery<TEntity>
        where TEntity : EntityBase
    {
        [IdRequired]
        public Guid EntityId { get; set; }
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
                .Single(e => e.Id == query.EntityId);
        }
    }
}