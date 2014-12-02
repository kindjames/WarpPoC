
namespace Warp.Data.Entities
{
    public class TextResourceCode : EntityBase
    {
        public int TextResourceCodeId { get; set; }
        public string ResourceCode { get; set; }
        public bool ClientOverride { get; set; }
    }
}
