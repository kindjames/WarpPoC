
namespace Warp.Core.Command
{
    /// <summary>
    /// USed to Execute ICommand objects.
    /// </summary>
    public interface ICommandDispatcher
    {
        void Execute(ICommand command);
    }
}