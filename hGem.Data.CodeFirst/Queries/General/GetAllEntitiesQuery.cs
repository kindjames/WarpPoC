using System.Collections.Generic;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Core.Data;
using hGem.Data.Context;

namespace hGem.Data.Queries.General
{
    /// <summary>
    /// WARNING: This must not be used for obtaining all entities from the database, and then filtering later with LINQ, as the SQL will not reflect your requirements.
    /// </summary>
    public class GetAllEntitiesQuery<TEntity> : IQuery<IEnumerable<TEntity>>
        where TEntity : EntityBase
    {
    }

    public class GetAllEntitiesQueryHandler<TEntity> : IQueryHandler<GetAllEntitiesQuery<TEntity>, IEnumerable<TEntity>>
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public GetAllEntitiesQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> Handle(GetAllEntitiesQuery<TEntity> query)
        {
            return _dbContext.Set<TEntity>()
                .ToList();
        }
    }
}