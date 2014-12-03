using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    internal static class ContextExtensions
    {
        public static void AddRange<TEntity>(this IDbSet<TEntity> dbSet, IEnumerable<TEntity> entities)
            where TEntity : EntityBase
        {
            foreach (var entity in entities)
            {
                dbSet.Add(entity);
            }

            throw new Exception("count:" + dbSet.Count());
        }
    }
}