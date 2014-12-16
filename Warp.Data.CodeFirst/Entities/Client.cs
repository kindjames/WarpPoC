using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Enum;

namespace Warp.Data.Entities
{
    public class Client : EntityBase
    {
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public DateTime? DateValidFrom { get; set; }

        [Required]
        public virtual ClientStatus Status { get; set; }

        [Required]
        public virtual User AccountManager { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }
    }
}