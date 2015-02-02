using System;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Data.Context;

namespace hGem.Data.Commands.TextResources
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
