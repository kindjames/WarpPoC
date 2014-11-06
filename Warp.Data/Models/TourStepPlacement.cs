using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TourStepPlacement
    {
        public TourStepPlacement()
        {
            this.TourSteps = new List<TourStep>();
        }

        public int TourStepPlacementId { get; set; }
        public string Placement { get; set; }
        public virtual ICollection<TourStep> TourSteps { get; set; }
    }
}
