
namespace Warp.Core.Services.Dtos.TextResources
{
    public class SaveTextResourceDto : DtoBase
    {
        public string ResourceString { get; set; }
        public string ResourceIdentifierCode { get; set; }
        public int LanguageId { get; set; }
        public bool ClientOverridable { get; set; }
    }
}
