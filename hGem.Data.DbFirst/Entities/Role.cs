using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Role : EntityBase
    {
        public Role()
        {
            Users = new List<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}