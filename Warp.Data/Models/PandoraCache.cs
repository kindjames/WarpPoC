using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PandoraCache
    {
        public int PandoraCacheID { get; set; }
        public int AssessmentID { get; set; }
        public string Data { get; set; }
        public System.DateTime Expiry { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
    }
}
