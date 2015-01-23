using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Infrastructure.Util;
using Warp.Data.Context;
using Warp.Data.Entities;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for SaveTextResourceCommand aggregate
    /// </summary>
    public sealed class SaveTextResourceCommand : ICommand
    {
        public Guid Id { get; set; }
        public Guid LanguageId { get; set; }
        public string ResourceString { get; set; }
        public bool ClientOverridable { get; set; }
        public Guid ClientId { get; set; }
    }

    public sealed class SaveTextResourceCommandValidator : AbstractValidator<SaveTextResourceCommand>
    {
        public SaveTextResourceCommandValidator()
        {
            RuleFor(c => c.Id).NotEmptyGuid();
            RuleFor(c => c.LanguageId).NotEmptyGuid();
            RuleFor(c => c.ResourceString).NotEmpty();
        }
    }

    public sealed class SaveTextResourceCommandHandler : ICommandHandler<SaveTextResourceCommand>
    {
        private readonly ITextResourceDbContext _dbContext;
        private readonly IObjectMapper _objectMapper;

        public SaveTextResourceCommandHandler(ITextResourceDbContext dbContext, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _objectMapper = objectMapper;
        }

        public void Handle(SaveTextResourceCommand command)
        {   
            CheckArgument.NotNull(command, "command");

            var textResource = _objectMapper.MapTo<TextResource>(command);

            _dbContext.CreateOrUpdateEntity(textResource);

            _dbContext.SaveChanges();
        }       
    }
}
