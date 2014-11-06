using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PasswordQuestion
    {
        public int PasswordQuestionID { get; set; }
        public string Question { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
    }
}
