using System.Collections.Generic;
using Warp.Testing.Unit.Data.Commands.Clients;

namespace Warp.Testing.Unit.Data.Util
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