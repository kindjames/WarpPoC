using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AuditingDatabase
    {
        public int DatabaseID { get; set; }
        public int UserId { get; set; }
        public int OperationId { get; set; }
        public int IdentityId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Operation Operation { get; set; }
    }
}
