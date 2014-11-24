namespace Warp.Core.Infrastructure.Mapping
{
    public interface IMappingConfiguration<in TSource, out TDestination>
    {
        TDestination Map(TSource source);
    }
}