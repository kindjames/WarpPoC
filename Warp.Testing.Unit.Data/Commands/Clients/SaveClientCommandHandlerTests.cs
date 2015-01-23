using System;
using FluentValidation.TestHelper;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.Clients
{
    [Subject("Save Client Command Validator")]
    public class SaveClientCommandValidatorTests
    {
        public class When_saving_client : WithSubject<SaveClientCommandValidator>
        {
            static readonly Guid AccountManagerId = Guid.NewGuid();
            static readonly Guid CustomerId = Guid.NewGuid();

            Establish context = () =>
            {
                The<IDomainDbContext>()
                    .Users = new TestDbSet<User>
                    {
                        new User{ Id = AccountManagerId }
                    };

                The<IDomainDbContext>()
                    .Customers = new TestDbSet<Customer>
                    {
                        new Customer { Id = CustomerId }
                    };
            };

            It should_throw_an_error = () =>
            {
                Subject.ShouldHaveValidationErrorFor(c => c.Id, Guid.Empty);
            };
            
            //It should_throw_an_error = () =>
            //{
            //    Subject.ShouldHaveValidationErrorFor(c => c.Name, String.Empty);
            //};
        }
    }
}