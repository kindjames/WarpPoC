using System;

namespace Warp.Core.Infrastructure.Configuration
{
    public class ApplicationConfig : IApplicationConfig
    {
        public string DbContextName
        {
            get { return "WarpPoCContext"; }
        }

        public TimeSpan DefaultAccountLockoutTimeSpan
        {
            get { return new TimeSpan(0, 5, 0); }
        }

        public int MaxFailedAccessAttemptsBeforeLockout { get { return 5; } }
        public bool IsLockoutEnabled { get { return true; } }
    }
}