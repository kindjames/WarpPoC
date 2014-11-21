using System;

namespace Warp.Data.Entities
{
    public class ClientOrganisation
    {
        public int ClientOrganisationId { get; set; }
        public int ClientId { get; set; }
        public bool RegionActive { get; set; }
        public bool AreaActive { get; set; }
        public int BrandLevel { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public bool BrandActive { get; set; }
        public virtual Client Client { get; set; }
    }
}