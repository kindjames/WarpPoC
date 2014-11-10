namespace Warp.Data.Entities
{
    public partial class GroupUser
    {
        public int GroupUserID { get; set; }
        public int GroupID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual Group Group { get; set; }
    }
}
