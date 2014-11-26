using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    internal interface IDataFactory<out TEntity>
        where TEntity : EntityBase
    {
        TEntity[] Build();
    }
}