using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Operations;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;

namespace Warp.Data.Operations.Command.Clients
{
    public interface ISaveClientCommand : ICommand
    {
        Guid Id { set; }
        string Name { set; }
        Guid CustomerId { set; }
        string Code { set; }
        ClientStatus Status { set; }
        Guid AccountManagerId { set; }
        Guid LegacyClientId { set; }
    }

    public class SaveClientCommand : ISaveClientCommand
    {
        [Required]
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
        
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveClientCommand(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public IOperationResult Execute()
        {
            // Check whether client already exists for customer id and client code.
            //var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = CustomerId, ClientCode = Code };

            //if (_queryDispatcher.Execute(clientExistsQuery))
            //{
            //    throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            //}

            //// Validate Account Manager (user) exists.
            //if (!_queryDispatcher.Execute(new CheckEntityExistsQuery<User> { EntityId = AccountManagerId }))
            //{
            //    throw new DataEntityNotFoundException<User>(AccountManagerId, "Looking for Account Manager.");
            //}

            //// Validate customer exists.
            //if (!_queryDispatcher.Execute(new CheckEntityExistsQuery<Customer> { EntityId = CustomerId }))
            //{
            //    throw new DataEntityNotFoundException<Customer>(CustomerId);
            //}

            // All systems go!
            var clientEntity = _objectMapper.MapTo<Client>(this);

            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();
        }
    }
}