using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Tour
    {
        public Tour()
        {
            this.PageTours = new List<PageTour>();
            this.TourSteps = new List<TourStep>();
            this.TourUserRoles = new List<TourUserRole>();
        }

        public int TourID { get; set; }
        public string TourName { get; set; }
        public bool AlwaysShow { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PageTour> PageTours { get; set; }
        public virtual ICollection<TourStep> TourSteps { get; set; }
        public virtual ICollection<TourUserRole> TourUserRoles { get; set; }
    }
}
