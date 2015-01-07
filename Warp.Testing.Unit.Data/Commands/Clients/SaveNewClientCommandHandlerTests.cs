//using System;
//using System.Data.Entity;
//using AutoMapper;
//using Machine.Fakes;
//using Machine.Specifications;
//using Warp.Core.Exceptions;
//using Warp.Core.Infrastructure.AutoMapper;
//using Warp.Core.Query;
//using Warp.Data.Commands.Clients;
//using Warp.Data.Context;
//using Warp.Data.Entities;
//using Warp.Data.Queries.Clients;
//using Warp.Data.Queries.General;
//using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
//using MoqIt = Moq.It;

//namespace Warp.Testing.Unit.Data.Commands.Clients
//{
//    [Subject("Save New Client Command Handler")]
//    public class SaveNewClientCommandHandlerTests
//    {
//        public class When_saving_new_client_for_client_that_already_exists_with_same_customer_id_and_code :
//            WithSubject<SaveNewClientCommandHandler>
//        {
//            private static Exception _exception;
//            private static SaveNewClientCommand _command;

//            private Establish that = () =>
//            {
//                _command = new SaveNewClientCommand {Code = "TESTYEAH", CustomerId = 69};

//                The<IQueryDispatcher>()
//                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientExistsForCodeQuery>()))
//                    .Return(true);
//            };

//            private Because of = () => _exception = Catch.Exception(() => Subject.Execute(_command));

//            private It should_throw_an_error = () =>
//            {
//                _exception.ShouldNotBeNull();
//                _exception.ShouldBeOfExactType<ClientAlreadyExistsException>();
//            };
//        }

//        public class When_saving_new_client : WithSubject<SaveNewClientCommandHandler>
//        {
//            private static IDbSet<Client> _clientRepository;

//            private Establish that = () =>
//            {
//                _clientRepository = An<IDbSet<Client>>();

//                Configure(r => r.For<IObjectMapper>().Use<ObjectMapper>());
//                Configure(Mapper.Engine);

//                The<IQueryDispatcher>()
//                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckClientExistsForCodeQuery>()))
//                    .Return(false);

//                The<IQueryDispatcher>()
//                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckEntityExistsQuery<User>>()))
//                    .Return(true);

//                The<IQueryDispatcher>()
//                    .WhenToldTo(d => d.Execute(MoqIt.IsAny<CheckEntityExistsQuery<Customer>>()))
//                    .Return(true);

//                The<IDomainDbContext>()
//                    .Clients = _clientRepository;
//            };

//            private Because of = () => Subject.Execute(new SaveNewClientCommand());

//            private It should_add_new_client_to_the_client_repository = () =>
//                _clientRepository.WasToldTo(r =>
//                    r.Add(MoqIt.IsAny<Client>()));

//            private It should_call_SaveChanges_on_UoW = () =>
//                The<IDomainDbContext>()
//                    .WasToldTo(c => c.SaveChanges());
//        }
//    }
//}