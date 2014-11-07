using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ParameterOption
    {
        public int ParameterOptionId { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}
