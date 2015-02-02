using System.Collections.Generic;

namespace Warp.WebUI.ViewModels.User
{
    public class SelectUserViewModel : UserViewModel
    {
        public IEnumerable<UserViewModel> UserList { get; set; }
    }
}