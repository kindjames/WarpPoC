using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Operation
    {
        public Operation()
        {
        }

        public int OperationId { get; set; }
        public string Method { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
