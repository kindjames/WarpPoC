using System;
using hGem.Core.Exceptions.Data;
using hGem.Core.Infrastructure.Authentication;
using hGem.Core.Infrastructure.IoC;
using Machine.Fakes;
using Machine.Specifications;

namespace hGem.Testing.Unit.Core
{
    public class PasswordHasherTests
    {
        [Ignore("TBD")]
        public class When_calling_Execute_for_Command_where_CommandHandler_does_not_exist : WithSubject<PasswordHasher>
        {
            Establish context = () =>
            {
                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.HashPassword(""));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<CommandHandlerNotFoundException>();
            };

            static Exception _exception;
        }
    }
}