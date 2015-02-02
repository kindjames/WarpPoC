﻿using System;

namespace hGem.Core.Infrastructure.General
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