using System.ComponentModel.DataAnnotations;
using Warp.Core.Attributes;
using Warp.Core.Domain.Enum;

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

        [PopulateWith("NameLabelText")]
        public string NameLabelText { get; set; }

        [PopulateWith("CodeLabelText")]
        public string CodeLabelText { get; set; }

        [PopulateWith("StatusLabelText")]
        public string StatusLabelText { get; set; }

        [PopulateWith("AccountManagerLabelText")]
        public string AccountManagerLabelText { get; set; }

        [PopulateWith("SaveButtonText")]
        public string SaveButtonText { get; set; }
    }
}