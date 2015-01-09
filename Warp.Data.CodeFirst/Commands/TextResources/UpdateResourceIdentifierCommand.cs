using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;

namespace Warp.Data.Commands.TextResources
{
    public sealed class UpdateTextResourceIdentifierCommand : ICommand
    {
        public int Id { get; set; }

        
    }

    public sealed class UpdateTextResourceIdentifierCommandHandler : ICommandHandler<UpdateTextResourceIdentifierCommand>
    {

        
        public void Execute(UpdateTextResourceIdentifierCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
