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
                    TextResourceCode = "WelcomeText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    TextResourceCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    TextResourceCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    TextResourceCode = "UsernameText", 
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    TextResourceCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    Id = Guid.NewGuid(),
                    TextResourceCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
            };
        }
    }
}
