using Warp.Core.Enum;
using Warp.WebUI.Models.Users;

namespace Warp.WebUI.Models.Clients
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ClientStatus Status { get; set; }
        public UserViewModel AccountManager { get; set; }
    }
}