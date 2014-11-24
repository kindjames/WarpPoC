using System;

namespace Warp.Data.Entities
{
    public class Configuration
    {
        public int ConfigurationId { get; set; }
        public short ConfigurationItemId { get; set; }
        public byte ConfigurationSystemId { get; set; }
        public string Value { get; set; }
        public int LastUpdateAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ConfigurationItem ConfigurationItem { get; set; }
        public virtual ConfigurationSystem ConfigurationSystem { get; set; }
    }
}