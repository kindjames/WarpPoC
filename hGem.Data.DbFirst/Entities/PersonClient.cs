using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PersonClient
    {
        public int PersonClientId { get; set; }
        public int PersonId { get; set; }
        public int ClientId { get; set; }
        public int? PermissionTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}