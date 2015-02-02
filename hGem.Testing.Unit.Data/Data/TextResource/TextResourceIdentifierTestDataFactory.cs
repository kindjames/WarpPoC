using System;
using System.Collections.Generic;
using hGem.Data.Entities;
using hGem.Testing.Unit.Data.Util;

namespace hGem.Testing.Unit.Data.Data.TextResource
{
    public class TextResourceIdentifierTestDataFactory : ITestDataFactory<TextResourceIdentifier>
    {
        public IEnumerable<TextResourceIdentifier> Build()
        {
            return new[]
            {
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "WelcomeText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "UsernameText", 
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    ResourceIdentifierCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
            };
        }
    }
}
