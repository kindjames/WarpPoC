using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Page
    {
        public Page()
        {
            PageArticles = new List<PageArticle>();
            PageTours = new List<PageTour>();
        }

        public int PageId { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PageArticle> PageArticles { get; set; }
        public virtual ICollection<PageTour> PageTours { get; set; }
    }
}