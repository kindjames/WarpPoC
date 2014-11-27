using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class User : EntityBase
    {
        public int UserId { get; set; }

        [StringLength(100), Required]
        public string Forename { get; set; }

        [StringLength(100), Required]
        public string Surname { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }

        [StringLength(100), Required]
        public string Salt { get; set; }

        [StringLength(255), Required]
        public string Email { get; set; }

        [StringLength(255), Required]
        public string PasswordAnswer { get; set; }

        public string UserName { get; set; }

        public DateTime DateLastPasswordChange { get; set; }
        public bool ForcePasswordChange { get; set; }
        public int CustomerId { get; set; }
        public int DefaultUserRoleId { get; set; }
        public int DefaultLanguageId { get; set; }
        public int LegacyUserId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool AutoCloseToast { get; set; }
        public int PasswordQuestionId { get; set; }
        public DateTime DateOfLastActivity { get; set; }
        public DateTime? DateLastLockedOut { get; set; }
        public DateTime DateLastLoggedIn { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}