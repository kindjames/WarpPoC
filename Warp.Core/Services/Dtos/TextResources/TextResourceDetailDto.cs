using System;

namespace Warp.Core.Services.Dtos.TextResources
{
    public class TextResourceDetailDto
    {
        public string ResourceString { get; set; }
        public string ResourceIdentifierCode { get; set; }

        public string LanguageName { get; set; }
        public string LanguageCulture { get; set; }

        public string ClientName { get; set; }
    }
}
