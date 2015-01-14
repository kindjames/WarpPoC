using System.ComponentModel.DataAnnotations;

namespace Warp.WebUI.ViewModels.Account
{
    public class UserProfileModel
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}