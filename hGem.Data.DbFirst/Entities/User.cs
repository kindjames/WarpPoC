using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            Actions = new List<Action>();
            ActionComments = new List<ActionComment>();
            ActionUsers = new List<ActionUser>();
            BroadcastMessageUsers = new List<BroadcastMessageUser>();
            CustomerUsers = new List<CustomerUser>();
            Errors = new List<Error>();
            Events = new List<Event>();
            GroupUsers = new List<GroupUser>();
        }

        public int UserId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public DateTime DateLastPasswordChange { get; set; }
        public bool ForcePasswordChange { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        public int DefaultUserRoleId { get; set; }
        public int DefaultLanguageId { get; set; }
        public int LegacyUserId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool AutoCloseToast { get; set; }
        public int PasswordQuestionId { get; set; }
        public string PasswordAnswer { get; set; }
        public DateTime DateOfLastActivity { get; set; }
        public DateTime? DateLastLockedOut { get; set; }
        public DateTime DateLastLoggedIn { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }

        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
        public virtual ICollection<ActionUser> ActionUsers { get; set; }
        public virtual ICollection<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<Error> Errors { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}