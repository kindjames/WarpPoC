using System.Collections.Generic;

namespace Warp.Core.Infrastructure.Mapping
{
    /// <summary>
    /// Used to map objects.
    /// </summary>
    public interface IObjectMapper
    {
        /// <summary>
        /// Map from one object to another.
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="from"></param>
        /// <returns></returns>
        TTo Map<TFrom, TTo>(TFrom from);

        /// <summary>
        /// Map a collection of one type to a collection of another type.
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="from"></param>
        /// <returns></returns>
        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from);
    }
}