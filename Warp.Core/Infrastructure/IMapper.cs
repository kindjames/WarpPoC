namespace Warp.Core.Infrastructure
{
    public interface IMapper
    {
        TTo Map<TFrom, TTo>(TFrom from);
        TTo Map<TTo>(object from);
    }
}