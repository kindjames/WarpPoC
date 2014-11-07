using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            this.PersonAreas = new List<PersonArea>();
            this.PersonBranches = new List<PersonBranch>();
            this.PersonClients = new List<PersonClient>();
            this.PersonRegions = new List<PersonRegion>();
        }

        public int PermissionTypeID { get; set; }
        public string PermissionType1 { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PersonArea> PersonAreas { get; set; }
        public virtual ICollection<PersonBranch> PersonBranches { get; set; }
        public virtual ICollection<PersonClient> PersonClients { get; set; }
        public virtual ICollection<PersonRegion> PersonRegions { get; set; }
    }
}
