using System.Collections.Generic;
using FakeDbSet;

namespace Warp.Testing.Unit.Data.Util
{
    public static class EnumerableExtensions
    {
        public static InMemoryDbSet<TEntity> ToInMemoryDbSet<TEntity>(this IEnumerable<TEntity> entities)
            where TEntity : class
        {
            var memoryDbSet = new InMemoryDbSet<TEntity>(true);

            foreach (var entity in entities)
            {
                memoryDbSet.Add(entity);
            }

            return memoryDbSet;
        }
    }
}