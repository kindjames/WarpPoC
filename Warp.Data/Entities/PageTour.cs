using System;

namespace Warp.Data.Entities
{
    public class PageTour
    {
        public int PageTourId { get; set; }
        public int PageId { get; set; }
        public int TourId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Page Page { get; set; }
        public virtual Tour Tour { get; set; }
    }
}