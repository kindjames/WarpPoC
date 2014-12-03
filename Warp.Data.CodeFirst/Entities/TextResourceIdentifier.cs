
namespace Warp.Data.Entities
{
    public class TextResourceIdentifier : EntityBase
    {
        public int TextResourceCodeId { get; set; }
        public string ResourceCode { get; set; }
        public bool ClientOverridable { get; set; }
    }
}
