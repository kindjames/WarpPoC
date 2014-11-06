using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            this.Branches = new List<Branch>();
        }

        public int PersonID { get; set; }
        public int UserRoleID { get; set; }
        public int ClientID { get; set; }
        public int PersonStatusID { get; set; }
        public string JobTitle { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual Client Client { get; set; }
        public virtual PersonStatu PersonStatu { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
