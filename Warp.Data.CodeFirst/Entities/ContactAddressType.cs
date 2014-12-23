using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;

namespace Warp.Data.Entities
{
    public class ContactAddressType : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}