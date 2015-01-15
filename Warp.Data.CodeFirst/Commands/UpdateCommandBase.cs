using System;
using Warp.Core.Command;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Commands
{
    public abstract class UpdateCommandBase : ICommand
    {
        [IdRequired]
        public Guid Id { get; set; }
    }
}