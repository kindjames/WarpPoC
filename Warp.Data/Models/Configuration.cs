using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Configuration
    {
        public int ConfigurationID { get; set; }
        public short ConfigurationItemID { get; set; }
        public byte ConfigurationSystemID { get; set; }
        public string Value { get; set; }
        public int LastUpdateAdminID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public bool Active { get; set; }
        public virtual ConfigurationItem ConfigurationItem { get; set; }
        public virtual ConfigurationSystem ConfigurationSystem { get; set; }
    }
}
