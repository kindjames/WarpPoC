using System;
using System.Linq;
using AutoMapper;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Data.Commands.Clients;
using hGem.Data.Context;
using hGem.Data.Migrations;
using hGem.Testing.Unit.Data.Util;
using Machine.Fakes;
using Machine.Specifications;
using IObjectMapper = hGem.Core.Infrastructure.AutoMapper.IObjectMapper;

namespace hGem.Testing.Unit.Data.Commands.Clients
{
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

                Configure<IObjectMapper>(new ObjectMapper(Mapper.Engine));

                DbContext.SaveChanges();
            };

            Because of = () => Subject.Handle(Command);

            It should_have_added_the_client_to_the_context = () =>
                DbContext.Clients.ShouldContain(c => c.Name == Command.Name);
        }

        public class When_saving_an_existing_client : WithSubject<SaveClientCommandHandler>
        {
            static readonly MigrationsAndTestingContext DbContext = InMemoryDatabaseFactory.Build();
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

                Configure<IObjectMapper>(new ObjectMapper(Mapper.Engine));

                DbContext.SaveChanges();
            };

            Because of = () => Subject.Handle(_command);

            It should_have_updated_the_client_in_the_context = () =>
                DbContext.Clients.ShouldContain(c => c.Name == _command.Name);
        }
    }
}