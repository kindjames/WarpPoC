using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class PermissionType
    {
        public PermissionType()
        {
            PersonAreas = new List<PersonArea>();
            PersonBranches = new List<PersonBranch>();
            PersonClients = new List<PersonClient>();
            PersonRegions = new List<PersonRegion>();
        }

        public int PermissionTypeId { get; set; }
        public string PermissionType1 { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PersonArea> PersonAreas { get; set; }
        public virtual ICollection<PersonBranch> PersonBranches { get; set; }
        public virtual ICollection<PersonClient> PersonClients { get; set; }
        public virtual ICollection<PersonRegion> PersonRegions { get; set; }
    }
}