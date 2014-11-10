namespace Warp.Data.Entities
{
    public partial class PasswordReset
    {
        public int PasswordResetID { get; set; }
        public string Email { get; set; }
        public bool Successful { get; set; }
        public string Token { get; set; }
        public int UserID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
