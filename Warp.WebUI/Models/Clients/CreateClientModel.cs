using System.ComponentModel.DataAnnotations;
using Warp.Core.Attributes;
using Warp.Core.Enum;

namespace Warp.WebUI.Models.Clients
{
    public class CreateClientModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public ClientStatus Status { get; set; }

        //[Required]
        //public UserViewModel AccountManager { get; set; }

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

        // TODO: Remove once text resource service is in place.
        public CreateClientModel()
        {
            SaveButtonText = "Save";
        }
    }
}