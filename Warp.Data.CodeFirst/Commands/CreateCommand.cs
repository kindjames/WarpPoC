using Warp.Core.Command;

namespace Warp.Data.Commands
{
    public abstract class CreateCommand : ICommand
    {
        public int Id { get; internal set; }
    }
}
