
namespace Warp.Data.Entities
{
    public class TextResource : EntityBase
    {
        public int TextResourceId { get; set; }
        public int TextResourceCodeId { get; set; }
        public int LanguageId { get; set; }
        public string ResourceString { get; set; }
        public int ClientId { get; set; }
    }
}
