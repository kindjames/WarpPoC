using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PersonArea
    {
        public int PersonAreaId { get; set; }
        public int PersonId { get; set; }
        public int AreaId { get; set; }
        public int? PermissionTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Area Area { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}