using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Tour
    {
        public Tour()
        {
            PageTours = new List<PageTour>();
            TourSteps = new List<TourStep>();
            TourUserRoles = new List<TourUserRole>();
        }

        public int TourId { get; set; }
        public string TourName { get; set; }
        public bool AlwaysShow { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PageTour> PageTours { get; set; }
        public virtual ICollection<TourStep> TourSteps { get; set; }
        public virtual ICollection<TourUserRole> TourUserRoles { get; set; }
    }
}