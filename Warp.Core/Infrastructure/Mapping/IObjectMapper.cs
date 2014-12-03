using System.Collections.Generic;

namespace Warp.Core.Infrastructure.Mapping
{
    /// <summary>
    /// Used to map objects.
    /// </summary>
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom from);
        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from);
    }
}