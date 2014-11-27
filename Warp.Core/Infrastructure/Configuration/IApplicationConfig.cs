﻿using System;

namespace Warp.Core.Infrastructure.Configuration
{
    public interface IApplicationConfig
    {
        string DbContextName { get; }
        TimeSpan DefaultAccountLockoutTimeSpan { get; }
        int MaxFailedAccessAttemptsBeforeLockout { get; }
        bool IsLockoutEnabled { get; }
    }
}