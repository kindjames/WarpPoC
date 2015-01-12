using Warp.Core.Command;

namespace Warp.Data.Commands
{
    public abstract class CreateCommandBase : ICommand
    {
        public int Id { get; internal set; }
    }
}