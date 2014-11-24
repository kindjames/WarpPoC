using System.Data.Entity;

namespace Warp.Data.Infrastructure
{
    public interface IEntityMappingsResolver
    {
        void AddAllConfigurations(DbModelBuilder modelBuilder);
    }
}