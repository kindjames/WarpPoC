using System.Data.Entity;
using System.Linq;
using Warp.Core.Data;
using Warp.Data.Context;

namespace Warp.Data.Infrastructure
{
    public static class DbSetExtensions
    {
        public static bool DoesEntityExist<TEntity>(this IDbSet<TEntity> set, TEntity entity) 
            where TEntity : EntityBase
        {
            return set.Any(e => e.Id == entity.Id);
        }

        public static void Save<TEntity>(this IApplicationDbContext dbContext, TEntity entity)
            where TEntity : EntityBase
        {
            var dbSet = dbContext.Set<TEntity>();

            if (dbSet.DoesEntityExist(entity))
            {
                // Attach and flag as modified.
                dbContext.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                // Add to the context.
                dbSet.Add(entity);
            }
        }
    }
}