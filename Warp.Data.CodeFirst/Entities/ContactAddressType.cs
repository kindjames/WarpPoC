using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class ContactAddressType : EntityBase
    {
        public int ContactAddressTypeId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}