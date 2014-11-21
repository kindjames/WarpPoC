using System;

namespace Warp.Data.Entities
{
    public class PandoraCache
    {
        public int PandoraCacheId { get; set; }
        public int AssessmentId { get; set; }
        public string Data { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}