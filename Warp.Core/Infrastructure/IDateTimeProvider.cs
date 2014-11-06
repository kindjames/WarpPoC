using System;

namespace Warp.Core.Infrastructure
{
    /// <summary>
    /// Allows mocking or faking different dates / times when unit testing.
    /// </summary>
    public interface IDateTimeProvider
    {
        DateTime UtcNow();
        DateTime Today();
    }
}