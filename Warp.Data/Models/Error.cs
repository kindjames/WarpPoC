using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Error
    {
        public System.Guid ErrorId { get; set; }
        public Nullable<int> CauseBy { get; set; }
        public string Url { get; set; }
        public string Exception { get; set; }
        public virtual User User { get; set; }
    }
}
