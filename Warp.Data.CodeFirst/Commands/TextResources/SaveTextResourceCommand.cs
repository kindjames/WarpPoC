using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for SaveTextResourceCommand aggregate
    /// </summary>
    public sealed class SaveTextResourceCommand : ICommand
    {
        public int Id { get; set; }

        // Required TextResourceIdentifier data
        [Required]
        public string ResourceIdentifierCode { get; set; }

        [Required]
        public bool ClientOverridable { get; set; }

        // Required TextResource data
        [IdRequired]
        public int LanguageId { get; set; }

        // Populated after successful TextResourceIdentifier validation(Here or in Dispatcher?)
        public int ResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }

    }

    public sealed class SaveTextResourceCommandHandler : ICommandHandler<SaveTextResourceCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly ICommandDispatcher _commandDispatcher;

        private SaveResourceIdentifierCodeCommand _resourceIdCodeCommand;
        private SaveResourceStringCommand _resourceStringCommand;


        public SaveTextResourceCommandHandler(ITextResourceDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper, ICommandDispatcher commandDispatcher)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
            _commandDispatcher = commandDispatcher;
        }

        public void Execute(SaveTextResourceCommand command)
        {
            // Test command correctness
            CheckArgument.NotNull(command, "command");

            // Initialise aggregate Commands
            _resourceIdCodeCommand = new SaveResourceIdentifierCodeCommand(){ ResourceIdentifierCode = command.ResourceIdentifierCode, ClientOverridable = command.ClientOverridable};
            _resourceStringCommand = new SaveResourceStringCommand(){ Id = command.Id, ResourceIdentifierCode = command.ResourceIdentifierCode, ClientOverridable = command.ClientOverridable};

            // Validation
            if (command.Id == 0)
            {

            }
            else
            {
                
            }

            _commandDispatcher.Execute(_resourceIdCodeCommand);
            _commandDispatcher.Execute(_resourceStringCommand);

            // Check command for correctness
            // Validate ResourceIdentifierCode
                // No. Get Associated TextResource data(Query on , populate and return DuplicateTextResourceDto to User(ResourceIdentifier and associated TextResource dto)
                // Yes(No duplicate).
                    // Validate ResourceString
                        // No.(Duplicate). Return duplicate data to User(Aggregized ResourceIdentifierDto and associated TextResourceDto)
                        // Yes.
                            // Invoke SaveNewResourceIdentifierCommand and return ResourceIdentifierId
                            // Invoke SaveNewResourceCommand and return TextResourceDetailsDto to User


            // ValidateResourceDataQuery
                // Validate ResourceIdentifier
            
        }
    }
}
