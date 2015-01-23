using System;
using AutoMapper;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.General;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;
using Warp.Services;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using ThenIt = Machine.Specifications.It;

namespace Warp.Testing.Unit.Services
{
    [Subject("Client Service")]
    public class ClientServiceTests
    {
        //public class When_calling__SaveClient__for_a_client_that_exists : WithSubject<ClientService>
        //{
        //    Establish context = () => _dto = new SaveClientDto { Id = 3 };

        //    Because of = () => Subject.SaveClient(_dto);

        //    ThenIt should_build_an_UpdateClientCommand = () =>
        //        The<IObjectMapper>()
        //            .WasToldTo(m => m.Map<SaveClientDto, UpdateClientCommand>(_dto));

        //    ThenIt should_execute_the_command_with_the_dispatcher = () =>
        //        The<ICommandDispatcher>()
        //            .WasToldTo(d => d.Execute(MoqIt.IsAny<ICommand>()));

        //    static SaveClientDto _dto;
        //}

        //public class When_calling__SaveClient__for_a_new_client : WithSubject<ClientService>
        //{
        //    Establish context = () =>
        //    {
        //        _dto = new SaveClientDto();
        //        _command = new CreateClientCommand();

        //        The<IObjectMapper>()
        //            .WhenToldTo(m => m.Map<SaveClientDto, CreateClientCommand>(_dto))
        //            .Return(_command);

        //        The<ICommandDispatcher>()
        //            .WhenToldTo(d => d.Execute(Param.IsAny<ICommand>()))
        //            .Callback(() => _command.WhenToldTo(c => c.Id).Return(new Random().Next()));
        //    };

        //    Because of = () => Subject.SaveClient(_dto);

        //    ThenIt should_build_a_SaveNewClientCommand = () =>
        //        The<IObjectMapper>()
        //            .WasToldTo(m => m.Map<SaveClientDto, CreateClientCommand>(_dto));

        //    ThenIt should_execute_the_command_with_the_dispatcher = () =>
        //        The<ICommandDispatcher>()
        //            .WasToldTo(d => d.Execute(MoqIt.IsAny<ICommand>()));

        //    ThenIt should_assign_the_new__ClientId__to_the__SaveClientDto__ = () =>
        //        _dto.Id.ShouldEqual(_command.Id);

        //    static SaveClientDto _dto;
        //    static CreateClientCommand _command;
        //}

        public class When_calling__GetClient__for_an_invalid_id : WithSubject<ClientService>
        {
            Because of = () => _exception = Catch.Exception(() => Subject.GetClient(Guid.Empty));

            ThenIt should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
            };

            static Exception _exception;
        }

        [Ignore("TBD")]
        public class When_calling__GetClient__for_a_client_that_does_not_exist : WithSubject<ClientService>
        {
            Establish context = () =>
            {
                _clientId = Guid.NewGuid();

                The<IDispatcher>()
                    .WhenToldTo(d => d.Execute(Param.IsAny<GetEntityQuery<Client>>()))
                    .Return((Client)null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.GetClient(_clientId));

            ThenIt should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<DataEntityNotFoundException<Client>>();
                _exception.ShouldContainErrorMessage(_clientId.ToString());
            };

            static Guid _clientId;
            static Exception _exception;
        }

        public class When_calling__GetClient__for_a_client_that_exists : WithSubject<ClientService>
        {
            Establish context = () =>
            {
                _clientId = Guid.NewGuid();

                Configure(r => r.For<IObjectMapper>().Use<ObjectMapper>());
                Configure(Mapper.Engine);

                The<IDispatcher>()
                    .WhenToldTo(d => d.Execute(Param.IsAny<GetEntityQuery<Client>>()))
                    .Return(new Client { Id = _clientId });
            };

            Because of = () => _response = Subject.GetClient(_clientId);

            ThenIt should_return_the_dto = () =>
                _response.Id.ShouldEqual(_clientId);

            static Guid _clientId;
            static ClientDto _response;
        }
    }
}