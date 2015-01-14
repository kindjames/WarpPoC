using System;

namespace Warp.Core.Infrastructure.Logging
{
    public interface ILoggingService
    {
        void Info(string message);
        void Info(Exception ex);

        void Warn(string message);
        void Warn(Exception ex);

        void Error(string message);
        void Error(Exception ex);
    }
}