using System;
using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data.TextResource
{
    public class LanguageTestDataFactory : ITestDataFactory<Language>
    {
        public Guid enLanguageId { get; set; }
        public Guid frLanguageId { get; set; }
        public Guid nlLanguageId { get; set; }

        public LanguageTestDataFactory()
        {
            enLanguageId = Guid.NewGuid();
            frLanguageId = Guid.NewGuid();
            nlLanguageId = Guid.NewGuid();
        }

        public IEnumerable<Language> Build()
        {
            return new[]
            {
                new Language {Id = enLanguageId, InvariantCulture = "en", Locale = "GB", Name = "English"},
                new Language {Id = frLanguageId, InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {Id = nlLanguageId, InvariantCulture = "nl", Locale = "NL", Name = "Dutch"}
            };
        }
    }
}
