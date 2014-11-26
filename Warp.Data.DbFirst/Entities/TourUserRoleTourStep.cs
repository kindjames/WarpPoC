using System;

namespace Warp.Data.DbFirst.Entities
{
    public class TourUserRoleTourStep
    {
        public int TourUserRoleTourStepId { get; set; }
        public int TourUserRoleId { get; set; }
        public int TourStepId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual TourStep TourStep { get; set; }
        public virtual TourUserRole TourUserRole { get; set; }
    }
}