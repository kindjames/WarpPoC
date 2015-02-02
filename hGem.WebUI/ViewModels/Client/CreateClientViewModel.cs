using System.ComponentModel.DataAnnotations;
using hGem.Core.Attributes;
using hGem.Core.Domain.Enum;
using hGem.WebUI.ViewModels.User;

namespace hGem.WebUI.ViewModels.Client
{
    public class CreateClientViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public ClientStatus Status { get; set; }

        [Required]
        public SelectUserViewModel AccountManager { get; set; }

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