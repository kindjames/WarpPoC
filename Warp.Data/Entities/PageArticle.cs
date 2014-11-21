using System;

namespace Warp.Data.Entities
{
    public class PageArticle
    {
        public int PageArticleId { get; set; }
        public int PageId { get; set; }
        public int ArticleId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Article Article { get; set; }
        public virtual Page Page { get; set; }
    }
}