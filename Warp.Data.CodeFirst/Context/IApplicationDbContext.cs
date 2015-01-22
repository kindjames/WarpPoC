using System.Data.Entity;
using System.Threading.Tasks;
using Warp.Core.Data;

namespace Warp.Data.Context
{
    public interface IApplicationDbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();

        void CreateOrUpdateEntity<TEntity>(TEntity entity)
            where TEntity : EntityBase;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}