using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using FakeDbSet;
using Machine.Specifications;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Commands.TextResources;
using Warp.Testing.Unit.Data.Queries.Languages;

namespace Warp.Testing.Unit.Data.Queries.TextResources
{
    [Subject("TextResource Validaation Query Tests")]
    public class ValidateResourceQueryHandlerTests
    {
        // Test base class
        public class Validate_TextResource_BaseContext
        {
            protected SaveTextResourceDto _dto;

            Establish context = () =>
            {
                _dto = new SaveTextResourceDto()
                {
                    ClientOverridable = false,
                    ClientId = 0,
                    ResourceIdentifierCode = "WelcomeText",
                    ResourceString = "Welcome!";
                };
            
            // Moq TextResource context
            The<ITextResourceDbContext>
                .WhenToldTo(tr => tr.TextResources)
                .Return(new InMemoryDbSet<TextResource>(true)
                {
                    new TextResource
                    {
                        Id = 1,
                        ResourceString = "Welcome!",
                        TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                        Language = new Language {Id = 1},
                        Client = new Client {Id = 0}
                    },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                },
                new TextResource
                {
                    Id = 1,
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = 1},
                    Language = new Language {Id = 1},
                    Client = new Client {Id = 0}
                }

                }),
                
The<TextResourceDbContext>
.WhenToldTo(tri => tri.TextResourceIdentifiers)
            };
        }

        [Subject("Validate_a_unique_resource_string")]
        public class Validate_a_unique_resource_string : Validate_TextResource_BaseContext
        {

        }
    }
}
