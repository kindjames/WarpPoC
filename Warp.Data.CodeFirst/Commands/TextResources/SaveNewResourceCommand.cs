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
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveNewResourceCommand : ICommand
    {
        public int Id { get; internal set; }

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

    public sealed class SaveNewResourceCommandHandler : ICommandHandler<SaveNewResourceCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveNewResourceCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveNewResourceCommand command)
        {
            // Is language supported?
                // Yes
                    // 
            throw new NotImplementedException();
        }
    }
}
