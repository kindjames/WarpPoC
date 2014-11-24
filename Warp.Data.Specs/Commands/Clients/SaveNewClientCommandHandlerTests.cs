using System.Data.Entity;
using Machine.Fakes;
using Machine.Specifications;
using System;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Query;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.ClientAccountManagers;
using Warp.Data.Queries.Clients;
using MoqIt = Moq.It;

namespace Warp.Data.Specs.Commands.Clients
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

        public class When_saving_new_client_and_account_manager_does_not_exist : WithSubject<SaveNewClientCommandHandler>
        {
            static Exception _exception;
            static SaveNewClientCommand _command;

            private Establish that = () =>
            {
                _command = new SaveNewClientCommand { AccountManagerAdminId = 32 };

                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientExistsForCodeQuery>()))
                    .Return(false);

                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientAccountManagerExistsQuery>()))
                    .Return(false);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_command));

            It should_throw_an_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<DataEntityNotFoundException<ClientAccountManager>>();
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

                The<IQueryDispatcher>()
                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientAccountManagerExistsQuery>()))
                    .Return(true);

                The<IObjectMapper>()
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
    }
}