
namespace hGem.Core.Services.Dtos.TextResources
{
    public class SaveTextResourceDto
    {
        public string ResourceString { get; set; }
        public string ResourceCode { get; set; }
        public int LanguageId { get; set; }
        public bool ClientOverridable { get; set; }
    }
}
