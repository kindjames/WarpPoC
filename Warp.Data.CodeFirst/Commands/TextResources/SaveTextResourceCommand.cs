using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

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

            var dbEntity = _dbContext.TextResources
                .FirstOrDefault(e => e.Id == command.Id);

            if (dbEntity == null)
            {
                _dbContext.TextResources.Add(_objectMapper.MapTo<TextResource>(command));
            }
            else
            {
                _objectMapper.Map(command, dbEntity);
            }

            _dbContext.SaveChanges();
        }       
    }
}