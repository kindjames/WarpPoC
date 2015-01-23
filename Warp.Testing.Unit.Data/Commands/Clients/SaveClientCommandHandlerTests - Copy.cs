using System;
using System.Linq;
using AutoMapper;
using Effort;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.Authentication;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Migrations;
using Warp.Data.Migrations.DataSeed;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.Clients
{
    internal static class InMemoryDatabaseFactory
    {
        public static MigrationsAndTestingContext Build()
        {
            var connection = DbConnectionFactory.CreateTransient();

            var context = new MigrationsAndTestingContext(new DateTimeProvider(), connection, true);

            DataFactoryResolver.Seed(context);

            return context;
        }
    }

    [Subject("Save Client Command Handler")]
    public class SaveClientCommandHandlerTests
    {
        public class When_saving_a_new_client : WithSubject<SaveClientCommandHandler>
        {
            static readonly MigrationsAndTestingContext DbContext = InMemoryDatabaseFactory.Build();
            static readonly SaveClientCommand Command = new SaveClientCommand
            {
                Id = Guid.NewGuid(),
                Code = "A",
                Name = "NEW CLIENT",
                AccountManagerId = Guid.NewGuid(),
                CustomerId = Guid.NewGuid()
            };

            Establish that = () =>
            {
                Configure(r => r.For<IDomainDbContext>().Use(DbContext));

                Command.AccountManagerId = DbContext.Users.First().Id;
                Command.CustomerId = DbContext.Customers.First().Id;

                The<IObjectMapper>()
                    .WhenToldTo(o => o.MapTo<Client>(Command, Param.IsAny<bool>()))
                    .Return(new Client
                    {
                        Id = Command.Id,
                        Name = Command.Name,
                        Code = Command.Code,
                        AccountManagerId = Command.AccountManagerId,
                        CustomerId = Command.CustomerId
                    });
                DbContext.SaveChanges();
            };

            Because of = () => Subject.Handle(Command);

            It should_have_added_the_client_to_the_context = () =>
                DbContext.Clients.ShouldContain(c => c.Name == Command.Name);
        }

        public class When_saving_an_existing_client : WithSubject<SaveClientCommandHandler>
        {
            static MigrationsAndTestingContext DbContext = InMemoryDatabaseFactory.Build();
            static SaveClientCommand _command;

            Establish that = () =>
            {
                Configure(r => r.For<IDomainDbContext>().Use(DbContext));
                var existingClient = DbContext.Clients.First();

                _command = new SaveClientCommand
                {
                    Id = existingClient.Id,
                    Code = existingClient.Code,
                    Status = existingClient.Status,
                    AccountManagerId = existingClient.AccountManager.Id,
                    CustomerId = existingClient.Customer.Id,
                    Name = "NEW CLIENT NAME",
                };

                The<IObjectMapper>()
                    .WhenToldTo(o => o.MapTo<Client>(_command, Param.IsAny<bool>()))
                    .Return(new Client
                    {
                        Id = _command.Id,
                        Name = _command.Name,
                        Code = _command.Code,
                        AccountManagerId = _command.AccountManagerId,
                        CustomerId = _command.CustomerId
                    });
                DbContext.SaveChanges();
            };

            Because of = () => Subject.Handle(_command);

            It should_have_updated_the_client_in_the_context = () =>
                DbContext.Clients.ShouldContain(c => c.Name == _command.Name);
        }
    }
}