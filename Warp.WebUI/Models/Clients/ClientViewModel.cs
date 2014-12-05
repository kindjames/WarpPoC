using System;

namespace Warp.WebUI.Models.Clients
{
    public class ClientViewModel
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string ClientStatusDescription { get; set; }

        public string AccountManagerName { get; set; }
    }
}