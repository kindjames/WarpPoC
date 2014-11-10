using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Group
    {
        public Group()
        {
            this.GroupUsers = new List<GroupUser>();
        }

        public int GroupID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
