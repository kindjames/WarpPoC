using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ApplicationLanguage
    {
        public ApplicationLanguage()
        {
            Translations = new List<Translation>();
        }

        public int ApplicationLanguageId { get; set; }
        public string NeutralCulture { get; set; }
        public string Locale { get; set; }
        public string Culture { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
    }
}