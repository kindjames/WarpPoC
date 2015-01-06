using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveNewResourceIdentifierCommand : ICommand
    {
        public int Id { get; internal set; }

    }
}
