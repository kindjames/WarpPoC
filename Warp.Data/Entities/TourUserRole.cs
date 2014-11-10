using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class TourUserRole
    {
        public TourUserRole()
        {
            this.TourUserRoleTourSteps = new List<TourUserRoleTourStep>();
        }

        public int TourUserRoleID { get; set; }
        public int TourID { get; set; }
        public int UserRoleID { get; set; }
        public bool HasViewedTour { get; set; }
        public bool PermanentlySkipTour { get; set; }
        public bool DelayTourTillNextLogin { get; set; }
        public string SessionId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual ICollection<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
    }
}
