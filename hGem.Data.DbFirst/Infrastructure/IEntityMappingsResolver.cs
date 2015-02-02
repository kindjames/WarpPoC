using System.Data.Entity;

namespace Warp.Data.DbFirst.Infrastructure
{
    public interface IEntityMappingsResolver
    {
        void AddAllConfigurations(DbModelBuilder modelBuilder);
    }
}