using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveResourceIdentifierCodeCommand : ICommand
    {
        [Required]
        public string ResourceIdentifierCode { get; set; }

        [Required]
        public bool ClientOverridable { get; set; }
    }

    public sealed class SaveResourceIdentifierCommandHandler : ICommandHandler<SaveResourceIdentifierCodeCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        
        public SaveResourceIdentifierCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveResourceIdentifierCodeCommand command)
        {
            CheckArgument.NotNull(command, "command");
        }
    }
}
