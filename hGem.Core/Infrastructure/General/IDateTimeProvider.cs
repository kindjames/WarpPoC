using System;

namespace hGem.Core.Infrastructure.General
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