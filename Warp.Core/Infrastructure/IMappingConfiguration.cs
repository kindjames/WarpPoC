namespace Warp.Core.Infrastructure
{
    public interface IMappingConfiguration<in TSource, out TDestination>
    {
        TDestination Map(TSource source);
    }
}