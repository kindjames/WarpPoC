﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    [Table("Users", Schema = "Client")]
    public class User : EntityBase
    {
        public User()
        {
            RoleGroups = new Collection<RoleGroup>();
        }

        [StringLength(100), Required]
        public string Forename { get; set; }

        [StringLength(100), Required]
        public string Surname { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }

        [StringLength(100), Required, DefaultValue("reGucpbCPtWBgsFKfNtH")]
        public string Salt { get; set; }

        [StringLength(255), Required, Index]
        public string Email { get; set; }

        [StringLength(255), Required]
        public string PasswordAnswer { get; set; }

        public DateTime DateLastPasswordChange { get; set; }
        public bool ForcePasswordChange { get; set; }
        public Guid DefaultUserRoleId { get; set; }
        public Guid DefaultLanguageId { get; set; }
        public int? LegacyUserId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool AutoCloseToast { get; set; }
        public int PasswordQuestionId { get; set; }
        public DateTime DateOfLastActivity { get; set; }
        public DateTime? DateLastLockedOut { get; set; }
        public DateTime DateLastLoggedIn { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
    }
}