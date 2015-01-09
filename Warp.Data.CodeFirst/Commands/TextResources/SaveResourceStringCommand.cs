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
    public sealed class SaveResourceStringCommand : ICommand
    {
        [IdRequired]
        public int Id { get; set; }

        [Required]
        public string ResourceIdentifierCode { get; set; }

        [Required]
        public bool ClientOverridable { get; set; }
    }

    public sealed class SaveResourceStringCommandHandler : ICommandHandler<SaveResourceStringCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveResourceStringCommandHandler(ITextResourceDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveResourceStringCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
