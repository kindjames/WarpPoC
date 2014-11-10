using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ApplicationLanguage
    {
        public ApplicationLanguage()
        {
            this.Translations = new List<Translation>();
        }

        public int ApplicationLanguageID { get; set; }
        public string NeutralCulture { get; set; }
        public string Locale { get; set; }
        public string Culture { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
    }
}
