using System.Collections.Generic;
using TestFactory.Util;
using Warp.Data.Entities;

namespace TestFactory.Data
{
    public class TextResourceTestDataFactory : ITestDataFactory<TextResource>
    {
        public IEnumerable<TextResource> BuildMemorySet()
        {
            return new[]
            {
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Welcome!",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Log In",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Password",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Username",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceCodeId = 1,
                    LanguageId = 1,
                    ClientId = 0
                },
            };
        }
    }
}
