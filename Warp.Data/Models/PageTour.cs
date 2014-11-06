using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PageTour
    {
        public int PageTourID { get; set; }
        public int PageID { get; set; }
        public int TourID { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual Page Page { get; set; }
    }
}
