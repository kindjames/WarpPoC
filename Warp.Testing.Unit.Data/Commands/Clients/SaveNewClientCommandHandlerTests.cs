using System;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.Clients
{
    [Subject("Save New Client Command Handler")]
    public class SaveNewClientCommandHandlerTests
    {
        public class When_saving_new_client_for_client_that_already_exists_with_same_customer_id_and_code : WithSubject<SaveNewClientCommandHandler>
        {
            static Exception _exception;
            static SaveNewClientCommand _command;

            Establish that = () =>
            {
                _command = new SaveNewClientCommand { Code = "TESTYEAH", CustomerId = 69 };

                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientExistsForCodeQuery>()))
                    .Return(true);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_command));

            It should_throw_an_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ClientAlreadyExistsException>();
            };
        }

        public class When_saving_new_client : WithSubject<SaveNewClientCommandHandler>
        {
            static IDbSet<Client> _clientRepository;

            private Establish that = () =>
            {
                _clientRepository = An<IDbSet<Client>>();

                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientExistsForCodeQuery>()))
                    .Return(false);

                The<IMappingEngine>()
                    .WhenToldTo(m => m.Map<SaveNewClientCommand, Client>(MoqIt.IsAny<SaveNewClientCommand>()))
                    .Return(new Client());

                The<IDomainDbContext>()
                    .Clients = _clientRepository;
            };

            Because of = () => Subject.Execute(new SaveNewClientCommand());

            It should_add_new_client_to_the_client_repository = () =>
                _clientRepository.WasToldTo(r =>
                    r.Add(MoqIt.IsAny<Client>()));

            It should_call_SaveChanges_on_UoW = () =>
                The<IDomainDbContext>()
                    .WasToldTo(c => c.SaveChanges());
        }

        public class When_saving_new_client_FOR_REAL : WithSubject<SaveNewClientCommandHandler>
        {
            Establish that = () =>
            {
                command = new SaveNewClientCommand
                {
                    Code = Guid.NewGuid().ToString(),
                    Name = Guid.NewGuid().ToString(),
                    Status = ClientStatus.Test,
                    AccountManagerId = 1,
                    CustomerId = 1,
                };

                Mapper.CreateMap<SaveNewClientCommand, Client>();

                Configure(Mapper.Engine);
                Configure(r => r.For<IValidator>().Use<DataAnnotationsValidator>());
                Configure(r => r.For<IQueryDispatcher>().Use<QueryDispatcher>());
                Configure(r => r.For<IDateTimeProvider>().Use<DateTimeProvider>());
                Configure(r => r.For<IDomainDbContext>().Use<DomainDbContext>());
                Configure(r => r.For<IApplicationConfig>().Use<ApplicationConfig>());
            
                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(new CheckClientExistsForCodeQueryHandler(The<IDomainDbContext>()));
            };

            Because of = () => Subject.Execute(command);

            It should_add_new_client_to_the_client_repository = () =>
            {
                var dbContext = new DomainDbContext(The<IApplicationConfig>(), The<IDateTimeProvider>());
                dbContext.Clients.FirstOrDefault(c => c.Name == command.Name).ShouldNotBeNull();
            };

            static SaveNewClientCommand command;
        }
    }
}