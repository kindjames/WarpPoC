using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Data
{
    public class LanguageTestDataFactory : ITestDataFactory<Language>
    {
        public IEnumerable<Language> BuildMemorySet()
        {
            return new[]
            {
                new Language {LanguageId = 1, InvariantCulture = "en", Locale = "GB", Name = "English"},
                new Language {LanguageId = 2, InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {LanguageId = 3, InvariantCulture = "nl", Locale = "NL", Name = "Dutch"},
                new Language {LanguageId = 4, InvariantCulture = "de", Locale = "DE", Name = "German"},
                new Language {LanguageId = 5, InvariantCulture = "oo", Locale = "AR", Name = "Pirate"}
            };
        }
    }
}
