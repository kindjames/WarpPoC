using System;

namespace hGem.Core.Infrastructure.Logging
{
    public class ConsoleLoggingService : ILoggingService
    {
        public void Info(string message)
        {
            Console.Write("INFO: " + message);
        }

        public void Info(Exception ex)
        {
            Console.Write("INFO: " + ex.Message);
        }

        public void Warn(string message)
        {
            Console.Write("WARNING: " + message);
        }

        public void Warn(Exception ex)
        {
            Console.Write("WARNING: " + ex.Message);
        }

        public void Error(string message)
        {
            Console.Write("ERROR: " + message);
        }

        public void Error(Exception ex)
        {
            Console.Write("ERROR: " + ex.Message);
        }
    }
}