using System;

namespace Warp.Data.Entities
{
    public class ClientHistory : EntityBase
    {
        public int ClientHistoryId { get; set; }
        public int ClientId { get; set; }
        public short ClientStatusId { get; set; }
        public string ClientName { get; set; }
        public string Code { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int EnteredByUserRoleId { get; set; }
        public string Notes { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }
    }
}