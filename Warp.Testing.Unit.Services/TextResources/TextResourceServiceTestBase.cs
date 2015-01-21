using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Machine.Fakes;
using Machine.Specifications;
using Moq.Language;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Entities;
using Warp.Services;
using Warp.Data.Context;
using FakeDbSet;


namespace Warp.Testing.Unit.Services.TextResources
{
    /// <summary>
    /// Test Base Class. Set up all test dummies and Moqs here fore use in inheriting test classes
    /// </summary>
    public class TextResourceServiceTestBase : WithSubject<TextResourceService>
    {
        Establish _context = () =>
        {
            var tri1 = new TextResourceIdentifier
            {
                Id = new Guid(), ResourceIdentifierCode = "WelcomeText", ClientOverridable = false
            };

            var tri2 = new TextResourceIdentifier { Id = new Guid()  };
            var tri3 = new TextResourceIdentifier { };
            var tri4 = new TextResourceIdentifier { };
            var tri5 = new TextResourceIdentifier { };
            var tri6 = new TextResourceIdentifier { };


            var _tr1 = new TextResource
            {
                Id = Guid.NewGuid(),
                ClientId = Guid.Empty,
                LanguageId = Guid.NewGuid(),
                ResourceIdentifierId = Guid.NewGuid(),
                ResourceString = "Welcome!",
            };

            The<ITextResourceDbContext>().WhenToldTo(tr => tr.TextResources).Return(new InMemoryDbSet<Warp.Data.Entities.TextResource>(true)
                {
                    //new TextResource { Id = new Guid(), ResourceIdentifierId = tri1.Id, LanguageId = 1, ResourceString = "Welcome!", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                    //new TextResource() { Id = new Guid(), ResourceCodeId = 2, ApplicationLanguageId = 1, ResourceString = "Username", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                

                });
        };
    }
}
