using System.Collections.Generic;

namespace hGem.Core.Infrastructure.AutoMapper
{
    /// <summary>
    /// Responsible for Mapping objects from one type to another.
    /// </summary>
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom from, bool createAnyMissingTypeMaps = true);
        TTo Map<TFrom, TTo>(TFrom from, TTo to, bool createAnyMissingTypeMaps = true);

        TTo MapTo<TTo>(object from, bool createAnyMissingTypeMaps = true);

        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from, bool createAnyMissingTypeMaps = true);
        IEnumerable<TTo> MapToMany<TTo>(IEnumerable<object> from, bool createAnyMissingTypeMaps = true);
    }
}