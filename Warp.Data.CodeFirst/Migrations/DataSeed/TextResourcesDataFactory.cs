using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using Warp.Core.Infrastructure.Authentication;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    public class TextResourcesDataFactory : IDataFactory
    {
        public int Order { get { return 2; } }

        public void AddDataToContext(InternalMigrationsInitializationContext context)
        {
            var languages = new[]
            {
                new Language {LanguageId = 1, InvariantCulture = "en", Locale = "GB", Name = "English"},
             new Language {LanguageId = 2, InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {LanguageId = 3, InvariantCulture = "nl", Locale = "NL", Name = "Dutch"},
                new Language {LanguageId = 4, InvariantCulture = "de", Locale = "DE", Name = "German"},
                new Language {LanguageId = 5, InvariantCulture = "oo", Locale = "AR", Name = "Pirate"}
            };

            var textResources = new[]
            {
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Welcome!",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },
                new TextResource
                {
                    TextResourceId = 1,
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {TextResourceIdentifierId = 1},
                    Language = new Language {LanguageId = 1},
                    Client = new Client {ClientId = 0},
                },                
            };

            var textResourceIdentifiers = new[]
                {
                    new TextResourceIdentifier
                    {
                        TextResourceIdentifierId = 1,
                        TextResourceCode = "WelcomeText",
                        ClientOverridable = true
                    },
                
                new TextResourceIdentifier
                {
                    TextResourceIdentifierId = 2,
                    TextResourceCode = "LoginText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceIdentifierId = 3,
                    TextResourceCode = "PasswordText",
                    ClientOverridable = true
                },
                new TextResourceIdentifier
                {
                    TextResourceIdentifierId = 4,
                    TextResourceCode = "UsernameText", 
                    ClientOverridable = true
                },

                new TextResourceIdentifier
                {
                    TextResourceIdentifierId = 5,
                    TextResourceCode = "RememberMeFor2WeeksText",
                    ClientOverridable = false
                },
                new TextResourceIdentifier
                {
                    TextResourceIdentifierId = 6,
                    TextResourceCode = "EmailOrTMDCIdText",
                    ClientOverridable = false
                }
                };

            context.TextResources.AddOrUpdate(textResources);
        }
    }
}