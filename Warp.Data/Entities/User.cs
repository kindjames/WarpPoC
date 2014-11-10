using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class User
    {
        public User()
        {
            this.Actions = new List<Action>();
            this.ActionComments = new List<ActionComment>();
            this.ActionUsers = new List<ActionUser>();
            this.BroadcastMessageUsers = new List<BroadcastMessageUser>();
            this.CustomerUsers = new List<CustomerUser>();
            this.Errors = new List<Error>();
            this.Events = new List<Event>();
            this.GroupUsers = new List<GroupUser>();
            this.UserRoles = new List<UserRole>();
        }

        public int UserID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public System.DateTime DateLastPasswordChange { get; set; }
        public bool ForcePasswordChange { get; set; }
        public string Email { get; set; }
        public int CustomerID { get; set; }
        public int DefaultUserRoleID { get; set; }
        public int DefaultLanguageID { get; set; }
        public int LegacyUserID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool AutoCloseToast { get; set; }
        public int PasswordQuestionID { get; set; }
        public string PasswordAnswer { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateOfLastActivity { get; set; }
        public Nullable<System.DateTime> DateLastLockedOut { get; set; }
        public System.DateTime DateLastLoggedIn { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public string ProvidorName { get; set; }
        public string ProvidorUserKey { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
        public virtual ICollection<ActionUser> ActionUsers { get; set; }
        public virtual ICollection<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<Error> Errors { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
