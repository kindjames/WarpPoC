namespace Warp.Core.Services.Dtos.TextResources
{
    public class LanguageDto
    {
        public int ApplicationLanguageId { get; set; }
        public string NeutralCulture { get; set; }
        public string Locale { get; set; }
        public string DisplayName { get; set; }
    }
}