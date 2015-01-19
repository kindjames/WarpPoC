using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
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

        public Guid Id { get; set; }
    }

    public sealed class SaveResourceIdentifierCodeCommandHandler : ICommandHandler<SaveResourceIdentifierCodeCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveResourceIdentifierCodeCommandHandler(ITextResourceDbContext dbContext, IDispatcher dispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
        }

        public void Handle(SaveResourceIdentifierCodeCommand command)
        {
            CheckArgument.NotNull(command, "command");
        }
    }
}
