using System;

namespace Warp.Data.Models
{
    public class Logo : EntityBase
    {
        public int LogoId { get; set; }
        public int ClientId { get; set; }
        public string LogoPath { get; set; }
        public string OriginalFileName { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
    }
}