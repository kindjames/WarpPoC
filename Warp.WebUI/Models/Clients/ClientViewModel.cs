using System;

namespace Warp.WebUI.Models.Clients
{
    public class ClientViewModel
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public short ClientStatusId { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public int AccountManagerAdminId { get; set; }
        public DateTime? DateValidFrom { get; set; }
    }
}