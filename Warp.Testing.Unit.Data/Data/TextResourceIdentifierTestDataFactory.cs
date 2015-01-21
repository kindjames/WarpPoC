using System;
using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data
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
