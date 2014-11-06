using System;
using System.Collections.Generic;

namespace Warp.Data.Models
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
            this.GroupUsers = new List<GroupUser>();
            this.UserImpersonationUserRoles = new List<UserImpersonationUserRole>();
            this.UserRoles = new List<UserRole>();
        }

        public int UserID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public System.DateTime LastPasswordChange { get; set; }
        public bool ForcePasswordChange { get; set; }
        public string Email { get; set; }
        public int CustomerID { get; set; }
        public int DefaultUserRoleID { get; set; }
        public int DefaultLanguageID { get; set; }
        public int LegacyUserID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool AutoCloseToast { get; set; }
        public int PasswordQuestionID { get; set; }
        public string PasswordAnswer { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
        public virtual ICollection<ActionUser> ActionUsers { get; set; }
        public virtual ICollection<BroadcastMessageUser> BroadcastMessageUsers { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<Error> Errors { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<UserImpersonationUserRole> UserImpersonationUserRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
