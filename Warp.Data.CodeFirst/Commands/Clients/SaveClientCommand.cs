using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Infrastructure;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;
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
        public SaveClientValidator()
        {
            RuleFor(c => c.Id).
        }

        public override ValidationResult Validate(SaveClientCommand command)
        {
            var result = new ValidationResult();
            result.Errors.Add();
            // Check whether client already exists for customer id and client code.
            if (!_dispatcher.Execute(new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code }))
            {
                throw new ClientAlreadyExistsException(command.CustomerId, command.Code);
            }

            // Validate Account Manager (user) exists.
            if (!_dispatcher.Execute(new CheckEntityExistsQuery<Customer> { EntityId = command.AccountManagerId }))
            {
                throw new DataEntityNotFoundException<User>(command.AccountManagerId, "Looking for Account Manager.");
            }

            // Validate customer exists.
            if (!_dispatcher.Execute(new CheckEntityExistsQuery<Customer> { EntityId = command.CustomerId }))
            {
                throw new DataEntityNotFoundException<Customer>(command.CustomerId);
            }

            return base.Validate(command);
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