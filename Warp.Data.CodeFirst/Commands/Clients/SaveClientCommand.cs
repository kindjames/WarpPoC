﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using FluentValidation;
using FluentValidation.Results;
using Warp.Core.Cqrs;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Infrastructure;
using Warp.Data.Infrastructure.Validation;
using Warp.Data.Queries.Clients;
using ValidationResult = FluentValidation.Results.ValidationResult;

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

    public class SaveClientValidator : AbstractValidator<SaveClientCommand>
    {
        readonly IDispatcher _dispatcher;

        public SaveClientValidator(IDispatcher dispatcher, EntityExistsValidator<User> userExistsValidator)
        {
            _dispatcher = dispatcher;

            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Code).NotEmpty();

            RuleFor(c => c.AccountManagerId).NotEmpty()
                .SetValidator(userExistsValidator).WithMessage("Looking for account manager");

            RuleFor(c => c.CustomerId).NotEmpty()
                .SetValidator(userExistsValidator);
        }

        public override ValidationResult Validate(SaveClientCommand command)
        {
            var result = base.Validate(command);

            // Check whether client already exists for customer id and client code.
            if (!_dispatcher.Execute(new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code }))
            {
                result.Errors.Add(new ValidationFailure("", ""));
            }

            return result;
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

            _dbContext.Save(client);

            _dbContext.SaveChanges();
        }
    }
}