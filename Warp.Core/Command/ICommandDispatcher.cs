
namespace Warp.Core.Command
{
    public interface ICommandDispatcher
    {
        void Execute(ICommand command);
    }
}