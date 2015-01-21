using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Util;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for SaveTextResourceCommand aggregate
    /// </summary>
    public sealed class SaveTextResourceCommand : ICommand
    {
        public Guid Id { get; set; }
         
        // Required TextResource data
        [IdRequired]
        public Guid LanguageId { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public Guid ClientId { get; set; }
    }

    public sealed class SaveTextResourceCommandHandler : ICommandHandler<SaveTextResourceCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        private SaveResourceIdentifierCommand _resourceIdCodeCommand;
        private SaveResourceStringCommand _resourceStringCommand;


        public SaveTextResourceCommandHandler(ITextResourceDbContext dbContext, IDispatcher queryDispatcher, IObjectMapper objectMapper, IDispatcher dispatcher)
        {
            _dbContext = dbContext;
            _dispatcher = queryDispatcher;
            _objectMapper = objectMapper;
            _dispatcher = dispatcher;
        }

        public void Handle(SaveTextResourceCommand command)
        {
            // Test command correctness
            CheckArgument.NotNull(command, "command");

            // Initialise aggregate Commands
            //_resourceIdCodeCommand = new SaveResourceIdentifierCommand(){ ResourceIdentifierCode = command.ResourceIdentifierCode, ClientOverridable = command.ClientOverridable};
            //_resourceStringCommand = new SaveResourceStringCommand(){ Id = command.Id, ResourceIdentifierCode = command.ResourceIdentifierCode, ClientOverridable = command.ClientOverridable};

            // Validation
            //if (command.Id = 0)
            //{

            //}
            //else
            //{
                
            //}

            _dispatcher.Execute(_resourceIdCodeCommand);
            _dispatcher.Execute(_resourceStringCommand);

            // Check command for correctness
          
            // Invoke SaveNewResourceIdentifierCommand and return ResourceIdentifierId
            // Invoke SaveNewResourceCommand and return TextResourceDetailsDto to User

        }       
    }
}
