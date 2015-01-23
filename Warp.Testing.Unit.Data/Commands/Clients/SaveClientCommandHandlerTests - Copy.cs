using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.Clients
{
    [Subject("Save Client Command Handler")]
    public class SaveClientCommandHandlerTests
    {
        public class When_saving_a_new_client : WithSubject<SaveClientCommandHandler>
        {
            static DomainDbContext _domainDbContext;
            readonly static SaveClientCommand Command = new SaveClientCommand { Id = Guid.NewGuid(), Name = "NEW CLIENT" };

            Establish that = () =>
            {
                _domainDbContext = An<DomainDbContext>(An<IApplicationConfig>(), An<IDateTimeProvider>());

                _domainDbContext.Clients = new TestDbSet<Client>
                {
                    new Client {Id = Guid.NewGuid(), Name = "BBB"},
                    new Client {Id = Guid.NewGuid(), Name = "ZZZ"},
                    new Client {Id = Guid.NewGuid(), Name = "AAA"},
                };

                _domainDbContext
                    .WhenToldTo(c => c.Set<Client>())
                    .Return(_domainDbContext.Clients as TestDbSet<Client>);

                Configure(r => r.For<IDomainDbContext>().Use(_domainDbContext));

                The<IObjectMapper>()
                    .WhenToldTo(o => o.MapTo<Client>(Command, Param.IsAny<bool>()))
                    .Return(new Client { Id = Command.Id, Name = Command.Name });
            };

            Because of = () => Subject.Handle(Command);

            It should_have_added_the_client_to_the_context = () =>
                _domainDbContext.Clients.ShouldContain(c => c.Name == Command.Name);
        }

        public class When_saving_an_existing_client : WithSubject<SaveClientCommandHandler>
        {
            static DomainDbContext _domainDbContext;
            static readonly Guid ExistingClientId = Guid.NewGuid();
            readonly static SaveClientCommand Command = new SaveClientCommand { Id = ExistingClientId, Name = "NEW CLIENT NAME" };

            Establish that = () =>
            {
                _domainDbContext = An<DomainDbContext>(An<IApplicationConfig>(), An<IDateTimeProvider>());

                _domainDbContext.Clients = new TestDbSet<Client>
                {
                    new Client {Id = ExistingClientId, Name = "OLD CLIENT NAME"},
                    new Client {Id = Guid.NewGuid(), Name = "ZZZ"},
                    new Client {Id = Guid.NewGuid(), Name = "AAA"},
                };

                //_domainDbContext.WhenToldTo(d => d.Entry(Param.IsAny<Client>())).Return();

                _domainDbContext
                    .WhenToldTo(c => c.Set<Client>())
                    .Return(_domainDbContext.Clients as TestDbSet<Client>);

                Configure(r => r.For<IDomainDbContext>().Use(_domainDbContext));

                The<IObjectMapper>()
                    .WhenToldTo(o => o.MapTo<Client>(Command, Param.IsAny<bool>()))
                    .Return(new Client { Id = Command.Id, Name = Command.Name });
            };

            Because of = () => Subject.Handle(Command);

            It should_have_updated_the_client_in_the_context = () =>
                _domainDbContext.Clients.ShouldContain(c => c.Name == Command.Name);
        }
    }
}