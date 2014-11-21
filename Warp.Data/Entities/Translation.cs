using System;

namespace Warp.Data.Entities
{
    public class Translation
    {
        public int TranslationId { get; set; }
        public int CodeResourceId { get; set; }
        public int ApplicationLanguageId { get; set; }
        public int ClientId { get; set; }
        public string TranslationString { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ApplicationLanguage ApplicationLanguage { get; set; }
        public virtual CodeResource CodeResource { get; set; }
    }
}