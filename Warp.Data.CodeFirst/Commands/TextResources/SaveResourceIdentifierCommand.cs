using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveResourceIdentifierCommand : ICommand
    {
        public Guid Id { get; set; }
        public string ResourceIdentifierCode { get; set; }
        public bool ClientOverridable { get; set; }
    }

    public sealed class SaveResourceIdentifierCommandValidator : AbstractValidator<SaveResourceIdentifierCommand>
    {
        public SaveResourceIdentifierCommandValidator()
        {
            RuleFor(c => c.ResourceIdentifierCode).NotEmpty().WithMessage("A Resource Identifier Code is required. e.g. 'WelcomeText'");
            RuleFor(c => c.ClientOverridable).NotEmpty().NotNull().WithMessage("Please specify if this TextResource is Client overridable.");
        }
    }

    public sealed class SaveResourceIdentifierCodeCommandHandler : ICommandHandler<SaveResourceIdentifierCommand>
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

        public void Handle(SaveResourceIdentifierCommand command)
        {
            CheckArgument.NotNull(command, "command");
        }
    }
}
