using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos.Client;
using Warp.Data.Commands.Clients;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Services.Specs
{
    [Subject("Client Service")]
    public class ClientServiceTests
    {
        public class When_calling_SaveClient_for_a_client_that_exists : WithSubject<ClientService>
        {
            private static SaveClientDto dto;

            Establish context = () => dto = new SaveClientDto { Id = 3 };

            Because of = () => Subject.SaveClient(dto);

            ThenIt should_build_an_UpdateClientCommand = () =>
                The<IObjectMapper>()
                    .WasToldTo(m => m.Map<SaveClientDto, UpdateClientCommand>(dto));

            ThenIt should_execute_the_command_with_the_dispatcher = () =>
                The<ICommandDispatcher>()
                    .WasToldTo(d => d.Execute(MoqIt.IsAny<ICommand>()));
        }

        public class When_calling_SaveClient_for_a_new_client : WithSubject<ClientService>
        {
            private static SaveClientDto dto;

            Establish context = () => dto = new SaveClientDto { Id = 0 };

            Because of = () => Subject.SaveClient(dto);

            ThenIt should_build_a_SaveNewClientCommand = () =>
                The<IObjectMapper>()
                    .WasToldTo(m => m.Map<SaveClientDto, SaveNewClientCommand>(dto));

            ThenIt should_execute_the_command_with_the_dispatcher = () =>
                The<ICommandDispatcher>()
                    .WasToldTo(d => d.Execute(MoqIt.IsAny<ICommand>()));
        }
    }
}