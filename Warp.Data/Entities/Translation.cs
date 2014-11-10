namespace Warp.Data.Entities
{
    public partial class Translation
    {
        public int TranslationID { get; set; }
        public int CodeResourceID { get; set; }
        public int ApplicationLanguageID { get; set; }
        public int ClientID { get; set; }
        public string TranslationString { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ApplicationLanguage ApplicationLanguage { get; set; }
        public virtual CodeResource CodeResource { get; set; }
    }
}
