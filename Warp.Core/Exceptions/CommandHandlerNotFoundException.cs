using System;
using Warp.Core.Command;

namespace Warp.Core.Exceptions
{
    public class CommandHandlerNotFoundException : Exception
    {
        public CommandHandlerNotFoundException(ICommand command)
            : base(BuildMessage(command))
        {
        }

        private static string BuildMessage(ICommand command)
        {
            return String.Concat("Unable to locate CommandHandler for ", command.GetType().Name, ". Command detail -> ",
                command);
        }
    }
}