﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class RoleGroup : EntityBase
    {
        public RoleGroup()
        {
            Roles = new List<Role>();
            Users = new List<User>();
        }

        public int RoleGroupId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}