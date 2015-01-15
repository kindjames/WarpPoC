using System;
using System.Linq;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.General
{
    public class CheckEntityExistsQuery<TEntity> : IQuery<bool>
        where TEntity : EntityBase
    {
        [IdRequired]
        public Guid EntityId { get; set; }
    }

    public class CheckEntityExistsQueryHandler<TEntity> : IQueryHandler<CheckEntityExistsQuery<TEntity>, bool>
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public CheckEntityExistsQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckEntityExistsQuery<TEntity> query)
        {
            return _dbContext.Set<TEntity>()
                .Any(e => e.Id == query.EntityId);
        }
    }
}