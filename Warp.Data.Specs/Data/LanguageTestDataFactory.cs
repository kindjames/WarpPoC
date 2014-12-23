using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Data
{
    public class LanguageTestDataFactory : ITestDataFactory<Language>
    {
        public IEnumerable<Language> Build()
        {
            return new[]
            {
                new Language {Id = 1, InvariantCulture = "en", Locale = "GB", Name = "English"},
                new Language {Id = 2, InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {Id = 3, InvariantCulture = "nl", Locale = "NL", Name = "Dutch"},
                new Language {Id = 4, InvariantCulture = "de", Locale = "DE", Name = "German"},
                new Language {Id = 5, InvariantCulture = "oo", Locale = "AR", Name = "Pirate"}
            };
        }
    }
}
