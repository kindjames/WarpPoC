using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Operation
    {
        public Operation()
        {
            this.AuditingDatabases = new List<AuditingDatabase>();
        }

        public int OperationId { get; set; }
        public string Method { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditingDatabase> AuditingDatabases { get; set; }
    }
}
