using System;
using System.Collections.Generic;
using System.Linq;
using hGem.Data.Entities;
using hGem.Testing.Unit.Data.Util;

namespace hGem.Testing.Unit.Data.Data.TextResource
{
    public class TextResourceTestDataFactory : ITestDataFactory<hGem.Data.Entities.TextResource>
    {
        #region TextResourceIds
        protected Guid tr1Id { get; set; }
        protected Guid tr2Id { get; set; }
        protected Guid tr3Id { get; set; }
        protected Guid tr4Id { get; set; }
        protected Guid tr5Id { get; set; }
        protected Guid tr6Id { get; set; }
        protected Guid tr7Id { get; set; }
        protected Guid tr8Id { get; set; }
        protected Guid tr9Id { get; set; }
        protected Guid tr10Id { get; set; }
        protected Guid tr11Id { get; set; }
        protected Guid tr12Id { get; set; }
        protected Guid tr13Id { get; set; }
        protected Guid tr14Id { get; set; }
        protected Guid tr15Id { get; set; }
        protected Guid tr16Id { get; set; }
        protected Guid tr17Id { get; set; }
        protected Guid tr18Id { get; set; }
        #endregion TextResourceIds

        #region TextResourceIdentifierIds
        public Guid tri1Id { get; set; }
        public Guid tri2Id { get; set; }
        public Guid tri3Id { get; set; }
        public Guid tri4Id { get; set; }
        public Guid tri5Id { get; set; }
        public Guid tri6Id { get; set; }

        #endregion TextResourceIdentifierIds
        
        public TextResourceTestDataFactory()
        {
            tr1Id = Guid.NewGuid();
            tr2Id = Guid.NewGuid();
            tr3Id = Guid.NewGuid();
            tr4Id = Guid.NewGuid();
            tr5Id = Guid.NewGuid();
            tr6Id = Guid.NewGuid();
            tr7Id = Guid.NewGuid();
            tr8Id = Guid.NewGuid();
            tr9Id = Guid.NewGuid();
            tr10Id = Guid.NewGuid();
            tr11Id = Guid.NewGuid();
            tr12Id = Guid.NewGuid();

            
        }

        public IEnumerable<hGem.Data.Entities.TextResource> Build()
        {
            var languages = new LanguageTestDataFactory().Build();
            var textResourceIdentifiers = new TextResourceIdentifierTestDataFactory().Build();

            return new[]
            {
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Welcome!",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new hGem.Data.Entities.TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                }
            };
        }
    }
}
