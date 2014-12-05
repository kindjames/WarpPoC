using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Users;

namespace Warp.Data.Specs.Queries.Users
{
    //[Subject("UserService Query Tests")]
    //public class UserDefaultLanguageQueryTests
    //{
    //    public class When_querying_for__LanguageId__for_user_that_does_not_exist : WithSubject<UserDefaultLanguageQuery>
    //    {
    //        Establish that = () =>
    //        {
    //            _query = new UserDefaultLanguageQuery { UserId = 25264 };

    //            The<ITextResourceDbContext>()
    //                .WhenToldTo(d => d.Users)
    //                .Return(new InMemoryDbSet<User>(true)
    //                {
    //                    new User { DefaultLanguageId = 1, UserId = 312},
    //                    new User { DefaultLanguageId = 1, UserId = 123},
    //                    new User { DefaultLanguageId = 1, UserId = 542},
    //                });
    //        };

    //        Because of = () => _result = Subject.Execute(_query);

    //        It should_return_zero = () =>
    //            _result.ShouldEqual(0);

    //        static int _result;
    //        static UserDefaultLanguageQuery _query;
    //    }

        public class When_querying_for__LanguageId__for_user_that_does_exist : WithSubject<GetDefaultLanguageForUserQueryHandler>
        {
            Establish that = () =>
            {
                _query = new GetDefaultLanguageForUserQuery { UserId = 25264 };

                The<ITextResourceDbContext>()
                    .WhenToldTo(d => d.Users)
                    .Return(new InMemoryDbSet<User>(true)
                    {
                        new User { DefaultLanguageId = 1, UserId = 5000},
                        new User { DefaultLanguageId = 1, UserId = 25264},
                    });
            };

            Because of = () => _result = Subject.Execute(_query);

            It should_return_the_correct_language_id = () =>
                _result.ShouldEqual(1);

            static int _result;
            static GetDefaultLanguageForUserQuery _query;
        }

    //}
}
