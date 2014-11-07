using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonArea
    {
        public int PersonAreaID { get; set; }
        public int PersonID { get; set; }
        public int AreaID { get; set; }
        public Nullable<int> PermissionTypeID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Area Area { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}
