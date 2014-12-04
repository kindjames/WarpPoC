
namespace Warp.Data.Entities
{
    public class Language : EntityBase
    {
        public int LanguageId { get; set; }
        public string InvariantCulture { get; set; }
        public string Locale { get; set; }
        public string Name { get; set; }
    }
}
