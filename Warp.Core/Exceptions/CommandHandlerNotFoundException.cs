using System;

namespace Warp.Core.Exceptions
{
    public class CommandHandlerNotFoundException : Exception
    {
        public CommandHandlerNotFoundException(Type commandType)
            : base(BuildMessage(commandType))
        {
        }

        private static string BuildMessage(Type commandType)
        {
            return String.Concat("Unable to locate CommandHandler for ", commandType.Name, ".");
        }
    }
}