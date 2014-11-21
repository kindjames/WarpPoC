using System;

namespace Warp.Data.Entities
{
    public class ReportRestrictionClient
    {
        public int ReportRestrictionClientId { get; set; }
        public int ReportId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedByUserRoleId { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int? RemovedByUserRoleId { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserRole UserRole1 { get; set; }
        public virtual Client Client { get; set; }
        public virtual Report Report { get; set; }
    }
}