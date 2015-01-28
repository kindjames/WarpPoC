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
using Warp.Testing.Unit;


namespace Warp.Testing.Unit.Services.TextResources
{
    /// <summary>
    /// Test Base Class. Set up all test dummies and Moqs here fore use in inheriting test classes
    /// </summary>
    public class TextResourceServiceUnitTestBase : WithSubject<TextResourceService>
    {
        static readonly IEnumerable<TextResource> _textResourceTestData;
        static readonly IEnumerable<TextResourceIdentifier> _textResourceIdentifierTestData;
        static readonly IEnumerable<Language> _languageTestData;
        static readonly IEnumerable<Client> _clientTestData;

        /// Single object test dummies
        /// Guids

        private static readonly Guid tri1Id = Guid.NewGuid();
        private static readonly Guid tri2Id = Guid.NewGuid();
        private static readonly Guid tri3Id = Guid.NewGuid();

        private static readonly Guid tr1Id = Guid.NewGuid();
        private static readonly Guid tr2Id = Guid.NewGuid();
        private static readonly Guid tr3Id = Guid.NewGuid();

        private static readonly Guid languageEnId = Guid.NewGuid();
        private static readonly Guid languageFrId = Guid.NewGuid();
        private static readonly Guid languageNlId = Guid.NewGuid();

        private static readonly Guid userLanguageEn = languageEnId;
        private static readonly Guid userLanguageFr = languageFrId;
        private static readonly Guid userLanguageNl = languageNlId;

        static readonly Guid clientId = Guid.NewGuid();

        private static Exception _exception;

        Establish that = () =>
        {
            _textResourceTestData = new TextResourceTestDataFactory().Build().ToList();

            #region Singletons

            #region TextResourceIdentifiers
            The<ITextResourceDbContext>().WhenToldTo(tri => tri.TextResourceIdentifiers).Return(_testD);
            #endregion TextResourceIdentifiers

            #region TextResources "En"

            TextResource trEn1 = new TextResource
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Welcome!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trEn2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Username",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trEn3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Password",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources

            #region TextResources "Fr"

            TextResource trFr1 = new TextResource
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Bienvenue!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trFr2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Nom d'utilisateur",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trFr3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Mot de passe",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources

            #region TextResources "Fr"

            TextResource trNl1 = new TextResource
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Welkom!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trNl2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Gebruikersnaam",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trNl3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Wachtwoord",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources

            #endregion Singletons

            #region Data Contexts
            The<ITextResourceDbContext>().WhenToldTo(tr => tr.TextResources).Return(new InMemoryDbSet<TextResource>(true)
                {
                    
 #region TextResources "En"
            new
            {
                
            }
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Welcome!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            },

            TextResource trEn2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Username",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trEn3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageEnId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Password",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources

            #region TextResources "Fr"

            TextResource trFr1 = new TextResource
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Bienvenue!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trFr2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Nom d'utilisateur",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trFr3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Mot de passe",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources

            #region TextResources "Fr"

            TextResource trNl1 = new TextResource
            {
                Id = tr1Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri1.Id,
                ResourceString = "Welkom!",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trNl2 = new TextResource
            {
                Id = tri2Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri2.Id,
                ResourceString = "Gebruikersnaam",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            TextResource trNl3 = new TextResource
            {
                Id = tri3Id,
                ClientId = Guid.Empty,
                LanguageId = languageFrId,
                ResourceIdentifierId = tri3Id,
                ResourceString = "Wachtwoord",
                Active = true,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            #endregion TextResources


                });
        };
    }

    //    public class TextResourceServiceUnitTestBaseWithClient : WithSubject<TextResourceService>
    //    {
    //        private readonly Guid tr1Id = Guid.NewGuid();

    //        Establish that = () =>
    //        {
    //var textResourceIdentifier_WithClient = new TextResourceIdentifier
    //            {
    //                Id = Guid.NewGuid(),
    //                ResourceIdentifierCode = "WelcomeText",
    //                ClientOverridable = true
    //            };

    //            var _textResourceWithClient = new TextResource
    //            {
    //                Id = Guid.NewGuid(),
    //                ClientId = Guid.NewGuid(),
    //                LanguageId = languageId,
    //                ResourceIdentifierId = textResourceIdentifierId_WithClient,
    //                ResourceString = "Howdy Y'All!"
    //            };            
    //        };

    //    }
}
