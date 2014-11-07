using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientOrganisation
    {
        public int ClientOrganisationID { get; set; }
        public int ClientID { get; set; }
        public bool RegionActive { get; set; }
        public bool AreaActive { get; set; }
        public int BrandLevel { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
        public bool BrandActive { get; set; }
        public virtual Client Client { get; set; }
    }
}
