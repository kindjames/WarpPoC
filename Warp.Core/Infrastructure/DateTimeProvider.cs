using System;

namespace Warp.Core.Infrastructure
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow()
        {
            return DateTime.UtcNow;
        }

        public DateTime Today()
        {
            return DateTime.Today;
        }
    }
}