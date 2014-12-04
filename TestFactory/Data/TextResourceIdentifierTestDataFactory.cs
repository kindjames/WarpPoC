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
                    TextResourceCode = "WelcomeText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 2,
                    TextResourceCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 3,
                    TextResourceCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 4,
                    TextResourceCode = "UsernameText", 
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    TextResourceCodeId = 5,
                    TextResourceCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    TextResourceCodeId = 6,
                    TextResourceCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
            };
        }
    }
}
