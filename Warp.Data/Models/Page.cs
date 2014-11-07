using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Page
    {
        public Page()
        {
            this.PageArticles = new List<PageArticle>();
            this.PageTours = new List<PageTour>();
        }

        public int PageID { get; set; }
        public string Url { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PageArticle> PageArticles { get; set; }
        public virtual ICollection<PageTour> PageTours { get; set; }
    }
}
