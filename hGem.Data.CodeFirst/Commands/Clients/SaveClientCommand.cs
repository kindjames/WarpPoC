﻿using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Domain.Enum;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;
using hGem.Data.Entities;
using hGem.Data.Infrastructure.Validation;

namespace hGem.Data.Commands.Clients
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
            var set = _dbContext.Set<Client>();

            var dbEntity = set.FirstOrDefault(e => e.Id == command.Id);

            if (dbEntity == null)
            {
                set.Add(_objectMapper.MapTo<Client>(command));
            }
            else
            {
                _objectMapper.Map(command, dbEntity);
            }

            _dbContext.SaveChanges();
        }
    }
}