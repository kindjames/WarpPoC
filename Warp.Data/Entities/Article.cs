using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
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
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<System.DateTime> DatePublished { get; set; }
        public virtual ICollection<ArticlePermission> ArticlePermissions { get; set; }
        public virtual ICollection<PageArticle> PageArticles { get; set; }
    }
}
