namespace Warp.Core.Services.Dtos.TextResources
{
    public class TextResourceDto
    {
        public int Id { get; set; }

        public int TextResourceCodeId { get; set; }

        public string ResourceCode { get; set; }

        public int LanguageId { get; set; }

        public string ResourceString { get; set; }

        public bool ClientOverride { get; set; }

        public int? ClientId { get; set; }

        // public bool ForceAdd { get; set; }
    }
}
