using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class ContactAddressType : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}