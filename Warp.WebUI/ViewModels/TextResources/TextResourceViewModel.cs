using System.ComponentModel.DataAnnotations;

namespace Warp.WebUI.ViewModels.TextResources
{
    public class TextResourceViewModel
    {
        public int TextResourceId { get; set; }

        [Required]
        public string TextResourceString { get; set; }

        [Required]
        public string TextResourceCode { get; set; }

        [Required]
        public int LanguageId { get; set; }

        [Required]
        public bool ClientOverride { get; set; }

        public bool ForceAdd { get; set; }
    }
}