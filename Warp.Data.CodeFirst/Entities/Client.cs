using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;
using Warp.Core.Enum;

namespace Warp.Data.Entities
{
    public class Client : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public DateTime? DateValidFrom { get; set; }

        [Required]
        public virtual ClientStatus Status { get; set; }

        [Required]
        public virtual User AccountManager { get; set; }

        public int AccountManagerId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }

        public int CustomerId { get; set; }
    }
}