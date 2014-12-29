using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data
{
    public class TextResourceTestDataFactory : ITestDataFactory<TextResource>
    {
        public IEnumerable<TextResource> Build()
        {
            return new[]
            {
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Welcome!",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                }
            };
        }
    }
}
