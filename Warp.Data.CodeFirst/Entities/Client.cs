using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Warp.Core.Data;
using Warp.Core.Domain.Enum;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Entities
{
    [DebuggerDisplay("Name = {Name}")]
    public class Client : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        public DateTime? DateValidFrom { get; set; }

        [Required]
        public ClientStatus Status { get; set; }
        
        [Required]
        public Guid AccountManagerId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User AccountManager { get; set; }

        public override string ToString()
        {
            return "Name = " + Name;
        }
    }
}