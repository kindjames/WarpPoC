using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ConfigurationSystem
    {
        public ConfigurationSystem()
        {
            this.Configurations = new List<Configuration>();
        }

        public byte ConfigurationSystemID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
    }
}
