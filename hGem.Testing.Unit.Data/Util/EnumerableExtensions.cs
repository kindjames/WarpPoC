﻿using System.Collections.Generic;

namespace hGem.Testing.Unit.Data.Util
{
    public static class EnumerableExtensions
    {
        internal static TestDbSet<TEntity> ToTestDbSet<TEntity>(this IEnumerable<TEntity> entities)
            where TEntity : class
        {
            var memoryDbSet = new TestDbSet<TEntity>();

            foreach (var entity in entities)
            {
                memoryDbSet.Add(entity);
            }

            return memoryDbSet;
        }
    }
}