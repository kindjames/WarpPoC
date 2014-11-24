using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Article
    {
        public Article()
        {
            ArticlePermissions = new List<ArticlePermission>();
            PageArticles = new List<PageArticle>();
        }

        public int ArticleId { get; set; }
        public string ArticleText { get; set; }
        public string ArticleTitle { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? DatePublished { get; set; }
        public virtual ICollection<ArticlePermission> ArticlePermissions { get; set; }
        public virtual ICollection<PageArticle> PageArticles { get; set; }
    }
}