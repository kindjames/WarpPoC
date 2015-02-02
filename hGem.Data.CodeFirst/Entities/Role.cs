﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    [Table("Roles", Schema = "Client")]
    public class Role : EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public virtual RoleGroup RoleGroup { get; set; }
    }
}