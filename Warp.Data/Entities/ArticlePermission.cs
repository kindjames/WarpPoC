namespace Warp.Data.Entities
{
    public partial class ArticlePermission
    {
        public int ArticlePermissionID { get; set; }
        public int ArticleID { get; set; }
        public int PermissionID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Article Article { get; set; }
    }
}
