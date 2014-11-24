using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ConfigurationSystem
    {
        public ConfigurationSystem()
        {
            Configurations = new List<Configuration>();
        }

        public byte ConfigurationSystemId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
    }
}