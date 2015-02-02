using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ConfigurationTypeMap : EntityTypeConfiguration<ConfigurationType>
    {
        public ConfigurationTypeMap()
        {
            // Primary Key
            HasKey(t => t.ConfigurationTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ConfigurationType");
            Property(t => t.ConfigurationTypeId).HasColumnName("ConfigurationTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
