using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warp.Data.Entities
{
    [Table("Roles", Schema = "Client")]
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