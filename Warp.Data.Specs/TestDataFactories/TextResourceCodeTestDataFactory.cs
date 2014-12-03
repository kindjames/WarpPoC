using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.TestDataFactories
{
    public class TextResourceCodeTestDataFactory : ITestDataFactory<TextResourceCode>
    {

        public IEnumerable<TextResourceCode> BuildMemorySet()
        {
            return new[]
            {
                new TextResourceCode
                {
                    TextResourceCodeId = 1,
                    ResourceCode = "WelcomeText",
                    ClientOverride = true
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 2,
                    ResourceCode = "LoginText",
                    ClientOverride = true
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 3,
                    ResourceCode = "PasswordText",
                    ClientOverride = true
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 4,
                    ResourceCode = "UsernameText", 
                    ClientOverride = true
                },

                new TextResourceCode
                {
                    TextResourceCodeId = 5,
                    ResourceCode = "RememberMeFor2WeeksText",
                    ClientOverride = false
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 6,
                    ResourceCode = "EmailOrTMDCIdText",
                    ClientOverride = false
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 7,
                    ResourceCode = "PasswordText",
                    ClientOverride = true
                },
                new TextResourceCode
                {
                    TextResourceCodeId = 8,
                    ResourceCode = "UsernameText",
                    ClientOverride = true
                }
            };
        }
    }
}
