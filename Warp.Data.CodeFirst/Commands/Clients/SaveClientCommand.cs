using System;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Domain.Enum;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Infrastructure.Validation;

namespace Warp.Data.Commands.Clients
{
    public class SaveClientCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CustomerId { get; set; }
        public string Code { get; set; }
        public ClientStatus Status { get; set; }
        public Guid AccountManagerId { get; set; }
        public Guid LegacyClientId { get; set; }
    }

    public class SaveClientCommandValidator : AbstractValidator<SaveClientCommand>
    {
        public SaveClientCommandValidator(EntityExistsValidator<User> userExistsValidator)
        {
            RuleFor(c => c.Id).NotEmptyGuid();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Code).NotEmpty();

            RuleFor(c => c.AccountManagerId)
                .NotEmptyGuid()
                .SetValidator(userExistsValidator)
                .WithMessage("Looking for account manager.");

            RuleFor(c => c.CustomerId)
                .NotEmptyGuid()
                .SetValidator(userExistsValidator)
                .WithMessage("Looking for customer.");
        }
    }
    
    public class SaveClientCommandHandler : ICommandHandler<SaveClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IObjectMapper _objectMapper;

        public SaveClientCommandHandler(IDomainDbContext dbContext, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _objectMapper = objectMapper;
        }

        public void Handle(SaveClientCommand command)
        {
            var client = _objectMapper.MapTo<Client>(command);

            _dbContext.CreateOrUpdateEntity(client);

            _dbContext.SaveChanges();
        }
    }
}