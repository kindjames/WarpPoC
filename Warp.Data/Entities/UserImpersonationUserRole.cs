namespace Warp.Data.Entities
{
    public partial class UserImpersonationUserRole
    {
        public int UserImpersonationUserRoleID { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public int UserID { get; set; }
        public int UserRoleID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}
