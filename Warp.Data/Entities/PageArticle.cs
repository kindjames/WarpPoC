namespace Warp.Data.Entities
{
    public partial class PageArticle
    {
        public int PageArticleID { get; set; }
        public int PageID { get; set; }
        public int ArticleID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Article Article { get; set; }
        public virtual Page Page { get; set; }
    }
}
