using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class TourStepPlacement
    {
        public TourStepPlacement()
        {
            this.TourSteps = new List<TourStep>();
        }

        public int TourStepPlacementID { get; set; }
        public string Placement { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<TourStep> TourSteps { get; set; }
    }
}
