
namespace Warp.Core.Services.Dtos.TextResources
{
    public class SaveTextResourceDto
    {
        public int TextResourceId { get; set; }
        public string ResourceString { get; set; }
        public string ResourceCode { get; set; }
        public int LanguageId { get; set; }
        public bool ClientOverride { get; set; }
    }
}
