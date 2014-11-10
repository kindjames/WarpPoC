using System;

namespace Warp.Data.Entities
{
    public partial class PersonClient
    {
        public int PersonClientID { get; set; }
        public int PersonID { get; set; }
        public int ClientID { get; set; }
        public Nullable<int> PermissionTypeID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}
