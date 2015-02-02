using System.Data.Entity;
using System.Threading.Tasks;

namespace hGem.Data.Context
{
    public interface IApplicationDbContext
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();

        //void CreateOrUpdateEntity<TEntity>(Func<Client> entity)
        //    where TEntity : EntityBase;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}