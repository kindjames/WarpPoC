using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ConfigurationItem
    {
        public ConfigurationItem()
        {
            Configurations = new List<Configuration>();
        }

        public short ConfigurationItemId { get; set; }
        public string Name { get; set; }
        public byte ConfigurationTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ConfigurationType ConfigurationType { get; set; }
    }
}