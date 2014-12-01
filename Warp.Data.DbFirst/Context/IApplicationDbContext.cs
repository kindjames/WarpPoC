using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace Warp.Data.DbFirst.Context
{
    public interface IApplicationDbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();

        // Hooks into the DbContext.
        Database Database { get; }
        DbContextConfiguration Configuration { get; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}