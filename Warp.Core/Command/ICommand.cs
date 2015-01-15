using System;

namespace Warp.Core.Command
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}