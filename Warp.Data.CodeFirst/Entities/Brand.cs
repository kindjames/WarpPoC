
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class Brand : EntityBase
    {
        public int BrandId { get; set; }
        
        [Required]
        public string Name { get; set; }

        public bool Visible { get; set; }

        [Required]
        public virtual BrandStatus BrandStatus { get; set; }

        [Required]
        public virtual Client Client { get; set; }

        [Required]
        public virtual IndustrySector IndustrySector { get; set; }
    }
}