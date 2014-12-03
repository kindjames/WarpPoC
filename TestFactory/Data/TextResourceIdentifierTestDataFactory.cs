using System.Collections.Generic;
using TestFactory.Util;
using Warp.Data.Entities;

namespace TestFactory.Data
{
    public class TextResourceIdentifierTestDataFactory : ITestDataFactory<TextResourceIdentifier>
    {
        public IEnumerable<TextResourceIdentifier> BuildMemorySet()
        {
            return new[]
            {
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 1,
                    ResourceCode = "WelcomeText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 2,
                    ResourceCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 3,
                    ResourceCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 4,
                    ResourceCode = "UsernameText", 
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    TextResourceCodeId = 5,
                    ResourceCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 6,
                    ResourceCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
            };
        }
    }
}
