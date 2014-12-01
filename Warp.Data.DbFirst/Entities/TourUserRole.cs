using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class TourUserRole
    {
        public TourUserRole()
        {
            TourUserRoleTourSteps = new List<TourUserRoleTourStep>();
        }

        public int TourUserRoleId { get; set; }
        public int TourId { get; set; }
        public int UserRoleId { get; set; }
        public bool HasViewedTour { get; set; }
        public bool PermanentlySkipTour { get; set; }
        public bool DelayTourTillNextLogin { get; set; }
        public string SessionId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual ICollection<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
    }
}