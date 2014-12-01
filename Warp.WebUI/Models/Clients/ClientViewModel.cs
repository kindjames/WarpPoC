using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Infrastructure.Validation;

namespace Warp.WebUI.Models.Clients
{
    public class ClientViewModel
    {
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }

        [IdRequired]
        public short ClientStatusId { get; set; }

        [Required]
        public string Code { get; set; }

        [IdRequired]
        public int AccountManagerAdminId { get; set; }

        [IdRequired]
        public int CustomerId { get; set; }

        public DateTime? DateValidFrom { get; set; }
    }
}