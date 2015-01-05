using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;
using Warp.Core.Enum;

namespace Warp.Data.Entities
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