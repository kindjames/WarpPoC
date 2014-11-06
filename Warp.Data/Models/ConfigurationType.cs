using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ConfigurationType
    {
        public ConfigurationType()
        {
            this.ConfigurationItems = new List<ConfigurationItem>();
        }

        public byte ConfigurationTypeID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ConfigurationItem> ConfigurationItems { get; set; }
    }
}
