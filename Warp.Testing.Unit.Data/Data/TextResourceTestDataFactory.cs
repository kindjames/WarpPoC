using System;
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
                    Id = Guid.NewGuid(),
                    ResourceString = "Welcome!",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = new Language {Id = Guid.NewGuid()},
                    Client = new Client {Id = Guid.NewGuid()}
                }
            };
        }
    }
}
