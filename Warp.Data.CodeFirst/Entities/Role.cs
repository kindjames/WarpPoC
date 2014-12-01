using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class Role : EntityBase
    {
        public int RoleId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        public virtual RoleGroup RoleGroup { get; set; }
    }
}