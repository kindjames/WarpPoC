using System.ComponentModel.DataAnnotations;
using Warp.Core.Attributes;
using Warp.Core.Enum;

namespace Warp.WebUI.ViewModels.Client
{
    public class CreateClientViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public ClientStatus Status { get; set; }

        //[Required]
        //public UserViewModel AccountManagerId { get; set; }

        [PopulateWith(1)]
        public string NameLabelText { get; set; }

        [PopulateWith(1)]
        public string CodeLabelText { get; set; }

        [PopulateWith(1)]
        public string StatusLabelText { get; set; }

        [PopulateWith(1)]
        public string AccountManagerLabelText { get; set; }

        [PopulateWith(1)]
        public string SaveButtonText { get; set; }
    }
}