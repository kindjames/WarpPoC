using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Operation
    {
        public Operation()
        {
            AuditingDatabases = new List<AuditingDatabase>();
        }

        public int OperationId { get; set; }
        public string Method { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditingDatabase> AuditingDatabases { get; set; }
    }
}