using System;
using System.Collections.Generic;
using hGem.Data.Entities;
using hGem.Testing.Unit.Data.Data.TextResource;
using hGem.Testing.Unit.Data.Util;

namespace hGem.Testing.Unit.Data.Data
{
    public class UserTestDataFactory : ITestDataFactory<User>
    {
        public Guid user1Id { get; set; }
        public Guid user2Id { get; set; }
        public Guid user3Id { get; set; }

        public LanguageTestDataFactory langTestData { get; set; }

        public UserTestDataFactory()
        {
            user1Id = Guid.NewGuid();
            user2Id = Guid.NewGuid();
            user3Id = Guid.NewGuid();

            langTestData = new LanguageTestDataFactory();
        }

        public IEnumerable<User> Build()
        {
            return new[]
            {
                new User
                {
                    Id = user1Id,
                    DefaultLanguageId = langTestData.enLanguageId,
                    Forename = "English",
                    Surname = "Test User"
                },
                new User
                {
                    Id = user1Id,
                    DefaultLanguageId = langTestData.enLanguageId,
                    Forename = "French",
                    Surname = "Test User"
                },
                new User
                {
                    Id = user1Id,
                    DefaultLanguageId = langTestData.enLanguageId,
                    Forename = "Dutch",
                    Surname = "Test User"
                }
            };
        }
    }
}
