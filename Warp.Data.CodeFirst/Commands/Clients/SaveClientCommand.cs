using System;
using System.ComponentModel.DataAnnotations;
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

namespace Warp.Data.Commands.Clients
{
    public class SaveClientCommand : ICommand
    {
        [IdRequired]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [IdRequired]
        public Guid CustomerId { get; set; }

        [Required]
        public string Code { get; set; }

        [IdRequired]
        public ClientStatus Status { get; set; }

        [IdRequired]
        public Guid AccountManagerId { get; set; }

        public Guid LegacyClientId { get; set; }
    }
    
    public class SaveClientCommandHandler : ICommandHandler<SaveClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IObjectMapper _objectMapper;
        private readonly IDispatcher _dispatcher;
        private readonly IValidator _validator;

        public SaveClientCommandHandler(IDomainDbContext dbContext, IObjectMapper objectMapper, IDispatcher dispatcher, IValidator validator)
        {
            _dbContext = dbContext;
            _objectMapper = objectMapper;
            _dispatcher = dispatcher;
            _validator = validator;
        }

        public void Handle(SaveClientCommand command)
        {
            _validator.Validate(command);

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

            var client = _objectMapper.MapTo<Client>(this);

            _dbContext.Save(client);

            _dbContext.SaveChanges();
        }
    }
}