
using System;

namespace Warp.Core.Command
{
    /// <summary>
    /// USed to Execute ICommand objects.
    /// </summary>
    public interface ICommandDispatcher
    {
        void Execute(ICommand command);
        void Execute<TCommand>(Func<TCommand, TCommand> command)
            where TCommand : class, ICommand, new();
    }
}