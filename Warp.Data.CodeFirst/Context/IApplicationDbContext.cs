using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Warp.Core.Data;
using Warp.Data.Entities;

namespace Warp.Data.Context
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