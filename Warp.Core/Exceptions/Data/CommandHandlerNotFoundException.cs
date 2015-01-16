using System;

namespace Warp.Core.Exceptions.Data
{
    public class CommandHandlerNotFoundException : DataLayerException
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