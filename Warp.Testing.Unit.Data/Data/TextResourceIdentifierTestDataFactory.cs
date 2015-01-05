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
                    Id = 1,
                    TextResourceCode = "WelcomeText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = 2,
                    TextResourceCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = 3,
                    TextResourceCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    Id = 4,
                    TextResourceCode = "UsernameText", 
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    Id = 5,
                    TextResourceCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    Id = 6,
                    TextResourceCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
            };
        }
    }
}
