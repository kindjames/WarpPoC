using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;
using hGem.Core.Domain.Enum;

namespace hGem.Data.Entities
{
    public class Brand : EntityBase
    {
        [Required]
        public string Name { get; set; }

        public bool Visible { get; set; }

        [Required]
        public virtual BrandStatus Status { get; set; }

        [Required]
        public virtual Client Client { get; set; }

        [Required]
        public virtual IndustrySector IndustrySector { get; set; }
    }
}