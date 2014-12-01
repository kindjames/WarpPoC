using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class Role : EntityBase
    {
        public Role()
        {
            Users = new List<User>();
        }

        public int RoleId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
    }
}