using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveResourceStringCommand : ICommand
    {
        public string ResourceIdentifierCode { get; set; }
        public bool ClientOverridable { get; set; }
        public Guid Id  { get; set; }
    }

    public sealed class SaveResourceStringCommandHandler : ICommandHandler<SaveResourceStringCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveResourceStringCommandHandler(ITextResourceDbContext dbContext, IDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Handle(SaveResourceStringCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
