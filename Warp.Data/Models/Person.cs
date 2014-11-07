using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            this.Branches = new List<Branch>();
            this.PersonAreas = new List<PersonArea>();
            this.PersonBranches = new List<PersonBranch>();
            this.PersonBrands = new List<PersonBrand>();
            this.PersonClients = new List<PersonClient>();
            this.PersonRegions = new List<PersonRegion>();
        }

        public int PersonID { get; set; }
        public int UserRoleID { get; set; }
        public int ClientID { get; set; }
        public int PersonStatusID { get; set; }
        public string JobTitle { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual Client Client { get; set; }
        public virtual PersonStatu PersonStatu { get; set; }
        public virtual ICollection<PersonArea> PersonAreas { get; set; }
        public virtual ICollection<PersonBranch> PersonBranches { get; set; }
        public virtual ICollection<PersonBrand> PersonBrands { get; set; }
        public virtual ICollection<PersonClient> PersonClients { get; set; }
        public virtual ICollection<PersonRegion> PersonRegions { get; set; }
    }
}
