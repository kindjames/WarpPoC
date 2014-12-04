using System.Collections.Generic;
using FakeDbSet;

namespace TestFactory.Util
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