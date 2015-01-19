using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;

namespace Warp.Data.Commands.TextResources
{
    public sealed class UpdateTextResourceIdentifierCommand : ICommand
    {
        Guid ICommand.Id { get; set; }
    }

    public sealed class UpdateTextResourceIdentifierCommandHandler : ICommandHandler<UpdateTextResourceIdentifierCommand>
    {



        public void Handle(UpdateTextResourceIdentifierCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
