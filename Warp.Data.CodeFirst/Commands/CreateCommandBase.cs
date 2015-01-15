using System;
using Warp.Core.Command;

namespace Warp.Data.Commands
{
    public abstract class CreateCommandBase : ICommand
    {
        public Guid Id { get; internal set; }
    }
}