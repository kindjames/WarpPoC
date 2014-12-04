using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Data
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
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
            };
        }
    }
}
