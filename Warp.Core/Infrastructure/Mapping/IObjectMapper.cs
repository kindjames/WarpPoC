using System.Collections.Generic;

namespace Warp.Core.Infrastructure.Mapping
{
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom from);
        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from);
    }
}