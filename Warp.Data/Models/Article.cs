using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Article
    {
        public Article()
        {
            this.ArticlePermissions = new List<ArticlePermission>();
            this.PageArticles = new List<PageArticle>();
        }

        public int ArticleID { get; set; }
        public string ArticleText { get; set; }
        public string ArticleTitle { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
        public virtual ICollection<ArticlePermission> ArticlePermissions { get; set; }
        public virtual ICollection<PageArticle> PageArticles { get; set; }
    }
}
