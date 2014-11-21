using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Person
    {
        public Person()
        {
            Branches = new List<Branch>();
            PersonAreas = new List<PersonArea>();
            PersonBranches = new List<PersonBranch>();
            PersonBrands = new List<PersonBrand>();
            PersonClients = new List<PersonClient>();
            PersonRegions = new List<PersonRegion>();
        }

        public int PersonId { get; set; }
        public int UserRoleId { get; set; }
        public int ClientId { get; set; }
        public int PersonStatusId { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
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