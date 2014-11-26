using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BanClient
    {
        public int BanClientId { get; set; }
        public int ClientId { get; set; }
        public int AssessorId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}